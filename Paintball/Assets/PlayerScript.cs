using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    [SerializeField] private float moveSpeed = 7f; // private variable but make it available to unity editor for testing

    private void Update()
    {
        // Input keybinds
        Vector2 inputVector = new Vector2(0,0);
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized;

        // Allow to move character up, down, left, right.
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;


        transform.forward = moveDir;
        Debug.Log(Time.deltaTime);
    }
}
