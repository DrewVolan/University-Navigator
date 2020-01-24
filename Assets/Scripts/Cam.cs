using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cam : MonoBehaviour
{
    public GameObject cam;
    float moveSpeed = 70f;
    float turnSpeed = 80f;
    public Canvas canvas;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            cam.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            cam.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            cam.transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            cam.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            cam.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            cam.transform.Translate(Vector3.up * -moveSpeed * Time.deltaTime);
    }
}