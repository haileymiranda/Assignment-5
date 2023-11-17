using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVert : MonoBehaviour
{

    float moveSpeedOne;
    float moveSpeedTwo;

    bool isitSo;
    // Start is called before the first frame update
    void Start()
    {

        //moveSpeedOne = 1f;
        //moveSpeedTwo = 6f;
        isitSo = true;

    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(0, 0, moveSpeedOne * Time.deltaTime);

        if (transform.position.z >= 8.15f)
        {

            moveSpeedOne = 0f;
            isitSo = false;
            moveSpeedTwo = -6f;
        }

        if (transform.position.z <= -7.5f)
        {
            moveSpeedTwo = 0f;
            isitSo = true;

            moveSpeedOne = 1f;
        }
        if (isitSo == true)
        {


            transform.Translate(0, 0, moveSpeedOne * Time.deltaTime);

        }

        if (isitSo == false)
        {

            transform.Translate(0, 0, moveSpeedTwo * Time.deltaTime);


        }
    }
}