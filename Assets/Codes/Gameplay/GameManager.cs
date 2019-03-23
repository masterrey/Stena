using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject ball;
    public Transform respawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallKilled()
    {
        Invoke("CreateBall", 2);
    }

    public void CreateBall()
    {
        GameObject instancedball=Instantiate(ball, respawnpoint.position,respawnpoint.rotation);
        
        
    }
}
