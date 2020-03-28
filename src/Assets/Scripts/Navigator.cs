using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Navigator : MonoBehaviour
{
    NavMeshAgent main;
    [SerializeField] private GameObject startPositionObj;
    [SerializeField] private GameObject targetObj;
    TrailRenderer trailRenderer;
    public Dropdown startPositionCombobox;
    public Dropdown targetCombobox;
    int i = 0;
    public GameObject cam;
    public Dropdown cameraMode;
    void Start()
    {
        string navigatorNumber = startPositionCombobox.captionText.text;
        if (gameObject.name != "Navigator" + navigatorNumber[2])
        {
            this.enabled = false;
        }
        startPositionObj = GameObject.Find(startPositionCombobox.captionText.text);
        targetObj = GameObject.Find(targetCombobox.captionText.text);
        main = GetComponent<NavMeshAgent>();
        trailRenderer = GetComponent<TrailRenderer>();
        main.transform.position = new Vector3(0, startPositionObj.transform.position.y, 0);
        main.transform.position = startPositionObj.transform.position;
        trailRenderer.time = 0;
    }
    void Update()
    {
        main.SetDestination(targetObj.transform.position);
        if (i == 2)
            trailRenderer.time = 60;
        if (i < 2)
            i++;
        if (cameraMode.captionText.text == "От первого лица")
        {
            cam.transform.position = main.transform.position;
            cam.transform.rotation = main.transform.rotation;
        }
    }
}