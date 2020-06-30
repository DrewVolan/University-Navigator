using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cam : MonoBehaviour
{
    public GameObject cam;
    readonly float moveSpeed = 50f;
    public Canvas canvas;
    readonly float sensitivityHor = 9.0f;
    readonly float sensitivityVert = 9.0f;
    readonly float minimumVert = -90.0f;
    readonly float maximumVert = 90.0f;
    float _rotationX;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            cam.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            cam.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            cam.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            cam.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            cam.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            cam.transform.Translate(Vector3.up * -moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftControl) == false)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
/*    EventTrigger eventTrigger;
    public Dropdown startPositionDropdown;
    public Dropdown targetDropdown;
    MeshRenderer material;
    public Material doorMaterial;
    void Start()
    {
        var allObjects = FindObjectsOfType<GameObject>();
        navigatorScript = GetComponent<Navigator>();
        material = GetComponent<MeshRenderer>();
        for (int i = 0; i < allObjects.Length; i++)
        {
            print(allObjects[i].name);
            MeshRenderer[] meshRenderers = new MeshRenderer[allObjects.Length];
            meshRenderers[i] = allObjects[i].GetComponent<MeshRenderer>();
            if (meshRenderers[i].materials[0] == doorMaterial)
            {
                print("yes");
                startPositionDropdown.options.Add(new Dropdown.OptionData { text = allObjects[i].name });
            }
        }
    }
    void Start()
    {
        eventTrigger = GetComponent<EventTrigger>();
    }*/
