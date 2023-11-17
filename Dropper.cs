using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBuddy;
    [SerializeField] float timetoWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBuddy = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBuddy.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timetoWait)
        {
            Debug.Log("Three Seconds has passed; drop object!");
          
            renderer.enabled = true;
            rigidBuddy.useGravity = true;

        }

        Debug.Log(Time.time);


    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {


            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";

        }
    }
}
