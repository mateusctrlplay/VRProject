using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{

    public float force;
    public Rigidbody sphereRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        force = 1000f;

        sphereRigidbody = this.GetComponent<Rigidbody>();
        print(sphereRigidbody);
    }

    public void PushSphere()
    {
        sphereRigidbody.AddForce(0, force, 0);
    }

}
