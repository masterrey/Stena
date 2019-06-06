using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject center;
    public float force;
    Rigidbody rdb;
    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody>();
        rdb.AddForce(Vector3.forward * 50);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (center)
        {
            Vector3 dir = center.transform.position - transform.position;
            rdb.AddForce(dir.normalized * (force));
        }
        rdb.velocity = rdb.velocity.normalized * 6.2f;
    }
}
