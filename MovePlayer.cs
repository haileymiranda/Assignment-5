using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] float playerSpeed = 10f;

    float yValue;

    // Start is called before the first frame update
    void Start()
    {

        SetValueY();
        PrintInstructions();
        


    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();



    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game.");
        Debug.Log("Move your player with WASD or Arrow Keys");
        Debug.Log("Don't hit the wall or the objects!");

    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        transform.Translate(xValue, yValue, zValue);

    }

    void SetValueY()
    {

        yValue = 0f;
    }


}
