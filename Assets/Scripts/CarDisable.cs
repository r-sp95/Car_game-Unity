using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Car = GameObject.Find("FamilyCar");
        Rigidbody body = Car.GetComponent<Rigidbody>();
        body.isKinematic = true;

        print(Car);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
