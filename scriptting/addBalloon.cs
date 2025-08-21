using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addBalloon : MonoBehaviour
{
    public GameObject getVAR;
    public main_manageMent1 acessVAR;
    public List<GameObject> getPos = new List<GameObject>();
    public List<GameObject> receiveBall = new List<GameObject>();
    private List<string> randomPos;
    private int amount;
    public AudioSource effect;
    public AudioClip ball;
    public float timeCounter;
    private void Start()
    {
        randomPos = new List<string>() { "this", "pass"};
        acessVAR = getVAR.GetComponent<main_manageMent1>();
    }
    /*
    private void Update()
    {
        timeCounter += Time.deltaTime;
        if ((acessVAR.allow_ADD && acessVAR.action)&& receiveBall.Count == 0)
        {
            acessVAR.blackBall = null;
            receiveBall.AddRange(acessVAR.getBall);
            if (receiveBall.Count != 0 && timeCounter >2.0f) { addAction(); } 
            else { acessVAR.allow_ADD = false; receiveBall.Clear(); }
        }
    }
    private void addAction()
    {
        for(int i = getPos.Count - 1; i >= 0; i--)
        {
            string state = randomPos[Random.Range(0,randomPos.Count)];
            if (state == "this" && amount <=2)
            {
                GameObject getRanDomBall = receiveBall[Random.Range(0,receiveBall.Count)];
                Instantiate(getRanDomBall, getPos[i].transform.position,Quaternion.identity);
                receiveBall.Remove(getRanDomBall);
                amount++;
            }
            if (i == 0) {timeCounter = 0; acessVAR.allow_ADD = false;receiveBall.Clear();amount = 0;}
        }

    }
    */
}
