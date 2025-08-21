using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMA1 : MonoBehaviour
{
    public GameObject GetUiSet;
    public GameObject getVAR;
    private main_manageMent1 access_VAR;
    private Color red;
    private Color green;
    private Vector3 ColorPos;
    public AudioSource geteffect;
    public AudioClip click;
    private bool clicked;
    void Start()
    {
        access_VAR = getVAR.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        movement1();
    }
    void movement1()
    {
        if (!access_VAR.transitionEnd) 
        {
            StartCoroutine(disPlayUI1());  
            access_VAR.transitionEnd = true;
        }
    }
    public void buttonClickFunction()
    {

        if (!clicked)
        {
            StartCoroutine(disPlayUI());
            geteffect.clip = click;
            geteffect.Play();
            access_VAR.setToDefault = true;
            access_VAR.massage_to_target = true;
            access_VAR.main_ms = true;
            access_VAR.massageMain = true;
            access_VAR.allow_ADD = false;
            access_VAR.action = true;
            clicked = true;
        }
    }
    IEnumerator disPlayUI()
    {
        yield return new WaitForSeconds(0.5f);
        GetUiSet.SetActive(false);
        clicked = false;
    }
    IEnumerator disPlayUI1()
    {
        yield return new WaitForSeconds(0.5f);
        GetUiSet.SetActive(true);
    }
}
