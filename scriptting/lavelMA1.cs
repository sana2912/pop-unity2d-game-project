using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lavelMA1 : MonoBehaviour
{
    public GameObject getVAR;
    private main_manageMent1 access_VAR;
    public TMP_Text lavel;
    private int lavelNum;

    void Start()
    {
        access_VAR = getVAR.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        lavelNum = access_VAR.lavelNumBer;
        lavel.text = "LAVEL : "+lavelNum;
    }
}
