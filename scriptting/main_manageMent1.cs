using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_manageMent1 : MonoBehaviour
{
    public bool main_ms;
    public bool complete;
    public bool massage_to_target;
    public int lavelNumBer;
    public int Positioning_LM;
    public bool g_Action;
    public bool transitionEnd;
    public bool deleteMassage;
    public int targetPosition;
    public float Plus_Position;
    public bool massageMain;
    public bool setToDefault;
    public bool fallActionActive;
    public bool allow_ADD;
    public string blackBall;
    public List<string>  G_set= new List<string>();
    public List<GameObject> getBall = new List<GameObject>();
    public List<GameObject> setback_Ball = new List<GameObject>();
    public bool played;
    public bool action;

    public string getColor;

    private void Start()
    {
        Time.timeScale = 1f;
        complete = false;
        lavelNumBer = 4;
        Positioning_LM = 4;
        g_Action = false;
        transitionEnd = true;
        deleteMassage = false;
        targetPosition = 60;
        Plus_Position = 45;
        fallActionActive = false;
        allow_ADD = false;
        played = false;
        action = true;
        main_ms = true;
        massage_to_target = true;
        setToDefault = true;
        massageMain = true;
    }
    /*
    private void Update()
    {
        if (blackBall != null && getBall.Count == 7)
        {
            for (int i = getBall.Count - 1; i >= 0; i--)
            {
                if (getBall[i].name == blackBall)
                {
                    getBall.Remove(getBall[i]);
                }
            }
        }
        if (!fallActionActive && getBall.Count == 6)
        {
            getBall.Clear();
            getBall.AddRange(setback_Ball);
        }
    }
    */
}
