using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete1 : MonoBehaviour
{
    public GameObject getVAR;
    private main_manageMent1 access_VAR;
    private List<string> names = new List<string>() { "redBall", "blueskyball", "purpleBall", "yellowBall", "greenBall", "brightBlueBall", "pinkBall" };
    void Start()
    {
        access_VAR = getVAR.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        if (access_VAR.deleteMassage){deleteFunc();}      
    }
    void deleteFunc()
    {
        foreach(string ballName in names)
        {
            GameObject[] DELETE = GameObject.FindGameObjectsWithTag(ballName);
            foreach(GameObject deleteObject in DELETE)
            {
                Destroy(deleteObject);
            }
        }
        access_VAR.deleteMassage = false;
    }
}
