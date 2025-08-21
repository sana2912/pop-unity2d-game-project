using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadline1 : MonoBehaviour
{
    private GameObject positionSet;
    public GameObject getVar;
    private main_manageMent1 access;
    public AudioSource effect;
    public AudioClip erorEf;
    public GameObject getSet;
    public GameObject getBall;
    private Color failcolor;
    private GameObject getHittingOB;

    void Start()
    {
        failcolor = new Color(0.3396226f, 0.3396226f, 0.3396226f, 1.0f);
        access = getVar.gameObject.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        if (getSet||getBall == null)
        {
            getSet = GameObject.FindWithTag("set");
            getBall = GameObject.FindWithTag("goal");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!access.played)
        {
            Debug.Log("get hitting with other object");
            access.allow_ADD = false;
            access.fallActionActive = false;
            getHittingOB = collision.gameObject;
            Renderer getrenderer = getHittingOB.GetComponent<Renderer>();
            getrenderer.material.color = failcolor;
            effect.clip = erorEf;
            effect.Play();
            access.deleteMassage = true;
            Destroy(getBall.gameObject);
            StartCoroutine(setFailstate());
        }
    }
    IEnumerator setFailstate()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(getSet.gameObject);
        access.transitionEnd = false;
        access.lavelNumBer = 1;
        access.Positioning_LM = 1;
        access.Plus_Position = 45;
        access.targetPosition = 60;
    }
}
