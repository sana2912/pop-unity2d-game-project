using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalMA1 : MonoBehaviour
{
    public GameObject get_var;
    private main_manageMent1 access;
    public bool G_action;
    public string randomValue;
    private int itemIndex;

    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject g6;
    public GameObject g7;

    public List<GameObject> getPosition = new List<GameObject>();
    void Start()
    {
        access = get_var.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        G_action = access.G_set.Count == 4;
        if (G_action)
        {
            randomValue = access.G_set[Random.Range(0, access.G_set.Count)];
            itemIndex = access.G_set.IndexOf(randomValue);
            access.blackBall = randomValue;
            access.g_Action = false;
            access.played = false;
            action();
        }
    }
    private void action()
    {
        for(int i = getPosition.Count - 1; i >= 0; i--)
        {
            if(i == itemIndex)
            {
                switch (randomValue)
                {
                    case "ball1pr": Instantiate(g1, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                    case "ball2pr": Instantiate(g2, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                    case "ball3pr": Instantiate(g3, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                    case "ball4pr": Instantiate(g4, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                    case "ball5pr": Instantiate(g5, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                    case "ball6pr": Instantiate(g6, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                    case "ball7pr": Instantiate(g7, getPosition[i].transform.position, Quaternion.identity); access.G_set.Clear(); break;
                }
            }
        }

    }
}
