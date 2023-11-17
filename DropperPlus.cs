using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperPlus : MonoBehaviour
{
    [SerializeField] float waitingTime;
    [SerializeField] private GameObject dropObject;

    // Start is called before the first frame update
    void Start()
    {
        waitingTime = 2.5f;
        dropObject = GameObject.Find("DropperPlus");

        if (Time.time > waitingTime)
        {


            Instantiate(dropObject, transform.position, Quaternion.identity);


        }

    }

    // Update is called once per frame
    void Update()
    {


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
