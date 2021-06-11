using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolderController : MonoBehaviour
{

    public GameObject spaceshipGameObject;

    void Start()
    {
        spaceshipGameObject = GameObject.Find("Spaceship");
    }

    void Update()
    {
        if (!spaceshipGameObject.GetComponent<SpaceshipController>().isHidden)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, spaceshipGameObject.GetComponent<Rigidbody>().velocity.z);
        }
        else
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
