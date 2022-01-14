using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("lookaround");

        Vector3 moveCal = transform.right * x + transform.forward * z;
        controller.Move(moveCal * 6f * Time.deltaTime);

        GetComponent<Transform>().Rotate(Vector3.up * rot * 1.5f);
    }
}
