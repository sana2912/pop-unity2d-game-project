using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionAreaScript : MonoBehaviour
{
    public GameObject getVAR;
    public main_manageMent1 accessVAR;
    public float collisionStay;
    public int CollisionCount;

    private void Start()
    {
        accessVAR = getVAR.GetComponent<main_manageMent1>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        collisionStay += Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollisionCount++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CollisionCount--;
    }
    private void Update()
    {
        if (collisionStay >= 5.0f && accessVAR.action)
        {
            accessVAR.action = false;
        }
        if(CollisionCount == 0 && collisionStay != 0)
        {
            collisionStay = 0;
            accessVAR.action = true;
        }
    } 
}
