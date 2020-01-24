using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Buttons : MonoBehaviour
{
    Navigator navigatorScript;
    GameObject player;
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
    public void CreateRoad(Navigator navigatorScript)
    {
        navigatorScript.enabled = true;
    }
}