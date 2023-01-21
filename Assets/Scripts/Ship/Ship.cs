using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private float health = 100f;
    [SerializeField]
    private float maxHealth = 100f;

    private float steerSpeed;
    [SerializeField]
    [Range(1f, 10f)]
    private float steerForce = 5f;
    [SerializeField]
    [Range(0f, 25f)]
    private float maxSteerSpeed = 10f;
    [SerializeField]

    private float velocityDecay = 0.998f;
    private Vector2 accleration;

    [SerializeField]
    private float steerLength = 5f;
    private float middle;

    private float[] gearSpeeds = { 1f, 5f, 10f };
    private int engineGear = 0;

    [SerializeField]
    private ShipData data;

    private Rigidbody2D body;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        middle = transform.position.y;
        LoadData();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        SailForward();
    }

    public void SailForward()
    {
        accleration = new Vector2(0, steerSpeed);
        body.AddForce(accleration);

        //Limit steerspeed
        if (Mathf.Abs(body.velocity.y) > maxSteerSpeed) body.velocity = maxSteerSpeed * Mathf.Sign(body.velocity.y) * Vector2.right;

        body.velocity *= velocityDecay;
        if (body.velocity.magnitude < 0.001f) body.velocity = Vector2.zero;

        float newY = transform.position.y;

        //Bounce ship off camera boundaries (North and South Wall)
        if (Mathf.Abs(newY - middle) > steerLength)
        {
            newY = Mathf.Max(newY, middle - steerLength);
            newY = Mathf.Min(newY, middle + steerLength);

            transform.position = new Vector2(transform.position.x, newY);

            body.velocity *= new Vector2(1, -1);
        }
    }

    public void GearUp()
    {
        engineGear++;
        if (engineGear >= gearSpeeds.Length) engineGear = gearSpeeds.Length - 1;
    }

    public void GearDown()
    {
        engineGear--;
        if (engineGear < 0) engineGear = 0;
    }

    public void Steer(float direction)
    {
        steerSpeed = steerForce * direction;
    }

    public void StopSteer()
    {
        steerSpeed = 0f;
    }

    public void Die()
    {
        accleration = Vector2.zero;
        body.velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject flotie = collision.gameObject;
        if (flotie.tag == "Flotsam")
        {
            Flotsam flotsam = flotie.GetComponent<Flotsam>();
            DoDamage(flotsam.Damage);
        }
    }

    public void DoDamage(float amount)
    {
        health -= amount;
        if (health < 0) health = 0;
    }

    public void RepairShip()
    {
        health = maxHealth;
    }

    public void SaveData()
    {
        data.health = health;
        data.maxHealth = maxHealth;
    }

    public void LoadData()
    {
        health = data.health;
        maxHealth = data.maxHealth;
    }

    public Vector2 Position { get { return body.position; } }
    public Vector2 Velocity { get { return body.velocity; } }
    public float SailSpeed { get { return gearSpeeds[engineGear]; } }
    public float Health { get { return health; } }
    public string HealthFraction { get { return $"{health} / {maxHealth}"; } }
    public bool IsAlive { get { return Health > 0; }}
}
