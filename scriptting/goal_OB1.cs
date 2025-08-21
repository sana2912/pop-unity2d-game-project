using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal_OB1 : MonoBehaviour
{
    public GameObject getVAR;
    public GameObject getVAR2;
    public GameObject hittingOB;
    private main_manageMent1 access_VAR;
    private string myname;
    private string yourname;
    public GameObject getEf;
    public AudioSource effect;
    public AudioClip erorEf;
    public AudioClip completeEf;
    public AudioClip winner;
    public bool bellenaBle;
    public Color failcolor = new Color(0.3396226f, 0.3396226f, 0.3396226f,1.0f);
    
    void Start()
    {
        hittingOB = null;
        bellenaBle = true;
        getEf = GameObject.FindWithTag("effect");
        effect = getEf.gameObject.GetComponent<AudioSource>();
        yourname = null;
        myname = null;
        getVAR = GameObject.FindWithTag("GameController");
        getVAR2 = GameObject.FindWithTag("set");
        access_VAR = getVAR.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        if(yourname == null){myname = gameObject.name;setCollisionName();}       
    }
    void setCollisionName()
    {
        switch (myname)
        {
            case "G1(Clone)": yourname = "redBall"; break;
            case "G2(Clone)": yourname = "blueskyball"; break;
            case "G3(Clone)": yourname = "purpleBall"; break;
            case "G4(Clone)": yourname = "yellowBall"; break;
            case "G5(Clone)": yourname = "greenBall"; break;
            case "G6(Clone)": yourname = "brightBlueBall"; break;
            case "G7(Clone)": yourname = "pinkBall"; break;
        }
    }
    void OnCollisionEnter2D(Collision2D col_check)
    {
        if (bellenaBle) 
        {
            access_VAR.fallActionActive = true;
            effect.clip = completeEf;
            effect.Play();
            bellenaBle = false; 
        }
        if (col_check.gameObject.CompareTag(yourname) || col_check.gameObject.CompareTag("dead_line"))//lose function
        {
            if (!access_VAR.played) 
            {
                access_VAR.allow_ADD = false;
                access_VAR.fallActionActive = false;
                effect.clip = erorEf;
                effect.Play(); access_VAR.played = true;
                hittingOB = col_check.gameObject;
                Renderer renderer = hittingOB.GetComponent<Renderer>();
                renderer.material.color = failcolor;
                col_check.gameObject.tag = "fail";
                access_VAR.deleteMassage = true;
                StartCoroutine(setFailState());
            }
        }
        if (col_check.gameObject.CompareTag("target"))//win function
        {
            if (!access_VAR.played) 
            {
                access_VAR.allow_ADD = false;
                access_VAR.fallActionActive = false;
                effect.clip = winner;
                effect.Play(); 
                access_VAR.played = true;
                access_VAR.deleteMassage = true;
                StartCoroutine(setcelabratestate());
            }     
        }
    }
    IEnumerator setcelabratestate()
    {
        yield return new WaitForSeconds(1.5f);
        access_VAR.lavelNumBer++;
        access_VAR.Positioning_LM++;
        Destroy(gameObject);
        Destroy(getVAR2.gameObject);
        if (access_VAR.lavelNumBer > 4) { access_VAR.targetPosition += 20; access_VAR.Plus_Position = access_VAR.targetPosition - 15; }
        else { access_VAR.Plus_Position = access_VAR.targetPosition - 15; }
        access_VAR.transitionEnd = false;

    }
    IEnumerator setFailState()
    {
        yield return new WaitForSeconds(1.5f);
        access_VAR.lavelNumBer = 1;
        access_VAR.Positioning_LM = 1;
        access_VAR.Plus_Position = 45;
        access_VAR.targetPosition = 60;
        access_VAR.transitionEnd = false;
        Destroy(gameObject);
        Destroy(getVAR2.gameObject);
        Destroy(hittingOB);
    }
}
