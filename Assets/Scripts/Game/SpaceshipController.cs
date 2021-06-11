using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{

    public Rigidbody spaceshipRigibody;
    public Transform spaceshipTransform;
    public GameObject mainCameraGameObject;
    public GameObject gameManagerGameObject;

    public bool isHidden;

    void Start()
    {
        isHidden = false;

        spaceshipRigibody = this.GetComponent<Rigidbody>();
        spaceshipTransform = this.transform;

        mainCameraGameObject = Camera.main.gameObject;
        gameManagerGameObject = GameObject.Find("GameManager");

    }

    void Update()
    {

        //print(PlayerPrefs.GetFloat("shipSpeed"));

        spaceshipRigibody.velocity = transform.forward.normalized * PlayerPrefs.GetFloat("shipspeed");

        spaceshipTransform.rotation = mainCameraGameObject.transform.rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Obstacle")
        {
            gameManagerGameObject.GetComponent<GameController>().Destroyed();

            spaceshipTransform.position = Vector3.up * 10f;

            isHidden = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NextLevelCollider")
        {
            gameManagerGameObject.GetComponent<GameController>().NextLevel();
        }
    }
}
