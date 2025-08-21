using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class target_set1: MonoBehaviour
{
    public GameObject target1;
    public List<GameObject> targetGroup1 = new List<GameObject>();
    public List<GameObject> targetGroup2 = new List<GameObject>();
    public List<GameObject> targetGroup3 = new List<GameObject>();
    public List<GameObject> targetGroup4 = new List<GameObject>();
    public List<GameObject> targetGroup5 = new List<GameObject>();
    public List<GameObject> targetGroup6 = new List<GameObject>();
    private GameObject randomValue;
    private float speed;
    public GameObject getVAR;
    private main_manageMent1 access_VAR;
    public bool actionvalue;
    public int prePos;
    public AudioSource getAudio;
    public AudioClip transition;
    public bool played;
    void Start()
    {
        InvokeRepeating("actionstate", 1.0f, 10.0f);
        speed = 8;
        access_VAR = getVAR.GetComponent<main_manageMent1>();
    }
    void FixedUpdate()
    {
        if (actionvalue && access_VAR.fallActionActive) 
        {
            if (!played)
            {
                getAudio.clip = transition;
                getAudio.Play();
                played = true;
            }
            transform.position += new Vector3(0, -0.5f, 0) * Time.fixedDeltaTime * speed;
            if((prePos - transform.position.y) >= 7.0f)
            {
                prePos = Mathf.RoundToInt(transform.position.y);
                actionvalue = false;
                played = false;
            }
        }
    }
    void Update()
    {
        if (access_VAR.massage_to_target) { prePos = access_VAR.targetPosition; played = false; actionvalue = false; targetBuilder();}
    }
    private void actionstate()
    {
        if (access_VAR.fallActionActive)
        {
            if (!actionvalue) { actionvalue = true; }
        }
    }
    void targetBuilder()
    {
        transform.position = new Vector3(0,access_VAR.targetPosition,0);
        if (access_VAR.lavelNumBer == 1)
        {
            Instantiate(target1, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
        else if(access_VAR.lavelNumBer == 2)
        {
            randomValue = targetGroup1[Random.Range(0, targetGroup1.Count)];
            Instantiate(randomValue, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
        else if(access_VAR.lavelNumBer == 3)
        {
            randomValue = targetGroup2[Random.Range(0, targetGroup2.Count)];
            Instantiate(randomValue, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
        else if(access_VAR.lavelNumBer > 3 && access_VAR.lavelNumBer < 6)
        {
            randomValue = targetGroup3[Random.Range(0, targetGroup3.Count)];
            Instantiate(randomValue, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
        else if(access_VAR.lavelNumBer >5 && access_VAR.lavelNumBer < 8)
        {
            randomValue = targetGroup4[Random.Range(0, targetGroup4.Count)];
            Instantiate(randomValue, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
        else if (access_VAR.lavelNumBer > 7 && access_VAR.lavelNumBer < 13)
        {
            randomValue = targetGroup5[Random.Range(0, targetGroup5.Count)];
            Instantiate(randomValue, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
        else
        {
            randomValue = targetGroup6[Random.Range(0, targetGroup6.Count)];
            Instantiate(randomValue, transform.position, Quaternion.identity);
            access_VAR.massage_to_target = false;
        }
    }
}
