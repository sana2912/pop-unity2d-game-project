using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positioning1 : MonoBehaviour
{
    public GameObject get_var;
    private main_manageMent1 access;
    [SerializeField] private int counting = 0;

    void Start()
    {
        access = get_var.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        if (access.setToDefault){transform.position = new Vector3(transform.position.x, access.Plus_Position, transform.position.z);access.setToDefault = true; }
        if (access.complete && counting < access.Positioning_LM){ excute(); }
        if(counting == access.Positioning_LM && access.complete == false){ completeANDset(); } 
    }
    void excute()
    {
        access.Plus_Position = transform.position.y - 20.0f;
        transform.position = new Vector3(transform.position.x, access.Plus_Position, transform.position.z);
        counting++;
        access.complete = false;
    }
    void completeANDset()
    {
        counting = 0;
        access.main_ms = false;
        access.g_Action = true;
    }
}
