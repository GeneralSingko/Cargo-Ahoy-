using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotsam : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject despawnPoint;
    public SeaManager sea;
    private float damage = 30;
    private Rigidbody2D m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        m_rigidbody.velocity = Vector2.left * sea.GetSpeed();
        if (transform.position.x < despawnPoint.transform.position.x) gameObject.SetActive(false);
    }

    public void Spawn()
    {
        Vector3 point = respawnPoint.transform.position;
        transform.position = new Vector3(point.x + 1 - Random.value * 3, point.y - 5 + Random.value * 10f, 0f);
        gameObject.SetActive(true);
    }


    public float Damage { get { return damage; } }

}
