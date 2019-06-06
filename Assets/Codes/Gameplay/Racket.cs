using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    float racketmov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal")!=0)
        racketmov = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * racketmov *Time.deltaTime*200);
    }

    public void RightTurn()
    {
        racketmov =1;
    }
    public void LeftTurn()
    {
        racketmov =-1;
    }
    public void NeutralTurn()
    {
        racketmov = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
       // collision.rigidbody.velocity = Vector3.zero;
       // collision.rigidbody.AddForce((-transform.right+transform.forward) *200);
    }
}
