using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpercreator : MonoBehaviour
{
    public GameObject obj;
    public int qnty=4;
    // Start is called before the first frame update
    void Start()
    {
        for (float i = 0; i < qnty; i+=22.5f)
        {

            Instantiate(obj, transform.position + 
                new Vector3(Mathf.Sin(Mathf.Deg2Rad*i), 0, Mathf.Cos(Mathf.Deg2Rad *i) )*5, Quaternion.Euler(90, i-180, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
