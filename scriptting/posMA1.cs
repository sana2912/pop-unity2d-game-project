using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posMA1 : MonoBehaviour
{
    public GameObject getVAR;
    private main_manageMent1 accessVAR;
    void Start()
    {
        accessVAR = getVAR.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        if(accessVAR.lavelNumBer == 1){ transform.position = new Vector3(0, 73, 0);}
        else if (accessVAR.lavelNumBer == 2){transform.position = new Vector3(0, 53, 0);}
        else if (accessVAR.lavelNumBer == 3){transform.position = new Vector3(0, 33, 0);}
        else if (accessVAR.lavelNumBer >= 4){transform.position = new Vector3(0, 5, 0);}
    }
}
