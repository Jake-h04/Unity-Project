using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public GameObject propeller;
    private float speed = 1000;
    private Vector3 offset = new Vector3(0, 0, 360);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        propeller.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        // transform.rotate = propeller.transform.position + offset;
    }
}
