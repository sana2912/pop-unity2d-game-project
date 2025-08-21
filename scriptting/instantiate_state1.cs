using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate_state1 : MonoBehaviour
{
    public GameObject get_var;
    private main_manageMent1 access;
    //insert prefab game object to instant it;
    [SerializeField] List<GameObject> collum_Group1 = new List<GameObject>();
    [SerializeField] List<GameObject> collum_Group2 = new List<GameObject>();
    [SerializeField] List<GameObject> collum_Group3 = new List<GameObject>();
    [SerializeField] List<GameObject> collum_Group4 = new List<GameObject>();
    [SerializeField] List<GameObject> collum_Group5 = new List<GameObject>();
    [SerializeField] List<GameObject> collum_Group6 = new List<GameObject>();

    //call back item use for restore object in ball list
    public List<GameObject> callBackItem = new List<GameObject>();

    //insert position set
    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;
    public GameObject position5;
    public GameObject position6;

    //recieve position that we will put object
    public GameObject position_1;
    public GameObject position_2;
    public GameObject position_3;
    public GameObject position_4;
    public GameObject position_5;


    // create the random value for each position in state 2
    [SerializeField] private GameObject ramdstate2_1;
    [SerializeField] private GameObject ramdstate2_2;
    [SerializeField] private GameObject ramdstate2_3;
    [SerializeField] private GameObject ramdstate2_4;
    [SerializeField] private GameObject ramdstate2_5;

    private GameObject randomValue = null;//recieve the random object to instant for each position
    [SerializeField] private int Count;// instant1 routine counting
    [SerializeField] private int Count_1;// instant2 routine counting
    [SerializeField] private bool state;// check wheter instant1 or instant2 is active;

    public int lastUnit_count;// check wheter last instant is active;z

    void Start()
    {
        access = get_var.GetComponent<main_manageMent1>();
    }
    void Update()
    {
        if (access.main_ms)
        {
            if (!state) { instant_1(); if (Count > 5) { state = true; Count = 0; }; }
            else { instant_2(); if (Count_1 > 4) { state = false; Count_1 = 0; access.complete = true; }; }
        }
        if (access.g_Action && lastUnit_count < 4) { LastUnitAction(); }
    }
    void instant_1()
    {
        switch (Count)
        {
            case 0:
                randomValue = collum_Group1[Random.Range(0, collum_Group1.Count)];
                Instantiate(randomValue, position1.transform.position, Quaternion.identity);
                collum_Group2.Remove(randomValue);
                collum_Group1.Remove(randomValue);
                randomValue = null;
                ramdstate2_1 = null;
                Count++;
                break;
            case 1:
                randomValue = collum_Group2[Random.Range(0, collum_Group2.Count)];
                Instantiate(randomValue, position2.transform.position, Quaternion.identity);
                collum_Group3.Remove(randomValue);
                collum_Group2.Remove(randomValue);
                collum_Group1.Remove(randomValue);
                randomValue = null;
                ramdstate2_2 = null;
                Count++;
                break;
            case 2:
                randomValue = collum_Group3[Random.Range(0, collum_Group3.Count)];
                Instantiate(randomValue, position3.transform.position, Quaternion.identity);
                collum_Group4.Remove(randomValue);
                collum_Group3.Remove(randomValue);
                collum_Group2.Remove(randomValue);
                randomValue = null;
                Count++;
                break;
            case 3:
                randomValue = collum_Group4[Random.Range(0, collum_Group4.Count)];
                Instantiate(randomValue, position4.transform.position, Quaternion.identity);
                collum_Group5.Remove(randomValue);
                collum_Group4.Remove(randomValue);
                collum_Group3.Remove(randomValue);
                ramdstate2_3 = null;
                randomValue = null;
                Count++;
                break;
            case 4:
                randomValue = collum_Group5[Random.Range(0, collum_Group5.Count)];
                Instantiate(randomValue, position5.transform.position, Quaternion.identity);
                collum_Group6.Remove(randomValue);
                collum_Group5.Remove(randomValue);
                collum_Group4.Remove(randomValue);
                ramdstate2_4 = null;
                randomValue = null;
                Count++;
                break;
            case 5:
                randomValue = collum_Group6[Random.Range(0, collum_Group6.Count)];
                Instantiate(randomValue, position6.transform.position, Quaternion.identity);
                collum_Group5.Remove(randomValue);
                ramdstate2_5 = null;
                randomValue = null;
                Count++;
                break;
        }
    }
    void instant_2()
    {
        switch (Count_1)
        {
            case 0:
                randomValue = collum_Group1[Random.Range(0, collum_Group1.Count)];
                Instantiate(randomValue, position_1.transform.position, Quaternion.identity);
                ramdstate2_1 = randomValue;
                collum_Group1.Clear();
                collum_Group1.AddRange(callBackItem);
                collum_Group1.Remove(randomValue);
                collum_Group2.Remove(randomValue);
                randomValue = null;
                Count_1++;
                break;
            case 1:
                randomValue = collum_Group2[Random.Range(0, collum_Group2.Count)];
                Instantiate(randomValue, position_2.transform.position, Quaternion.identity);
                ramdstate2_2 = randomValue;
                collum_Group2.Clear();
                collum_Group2.AddRange(callBackItem);
                collum_Group2.Remove(randomValue);
                collum_Group3.Remove(randomValue);
                collum_Group2.Remove(ramdstate2_1);
                randomValue = null;
                Count_1++;
                break;
            case 2:
                randomValue = collum_Group3[Random.Range(0, collum_Group3.Count)];
                Instantiate(randomValue, position_3.transform.position, Quaternion.identity);
                ramdstate2_3 = randomValue;
                collum_Group3.Clear();
                collum_Group3.AddRange(callBackItem);
                collum_Group3.Remove(randomValue);
                collum_Group4.Remove(randomValue);
                collum_Group3.Remove(ramdstate2_2);
                randomValue = null;
                Count_1++;
                break;
            case 3:
                randomValue = collum_Group4[Random.Range(0, collum_Group4.Count)];
                Instantiate(randomValue, position_4.transform.position, Quaternion.identity);
                ramdstate2_4 = randomValue;
                collum_Group4.Clear();
                collum_Group4.AddRange(callBackItem);
                collum_Group4.Remove(randomValue);
                collum_Group5.Remove(randomValue);
                collum_Group4.Remove(ramdstate2_3);
                randomValue = null;
                Count_1++;
                break;
            case 4:
                randomValue = collum_Group5[Random.Range(0, collum_Group5.Count)];
                Instantiate(randomValue, position_5.transform.position, Quaternion.identity);
                ramdstate2_5 = randomValue;
                collum_Group5.Clear();
                collum_Group5.AddRange(callBackItem);
                collum_Group6.Clear();
                collum_Group6.AddRange(callBackItem);
                collum_Group5.Remove(randomValue);
                collum_Group5.Remove(ramdstate2_4);
                collum_Group6.Remove(randomValue);
                randomValue = null;
                Count_1++;
                break;
        }
    }
    void LastUnitAction()
    {
        GameObject ranDomvar;
        switch (lastUnit_count)
        {
            case 0:
                ranDomvar = collum_Group2[Random.Range(0, collum_Group2.Count)];
                access.G_set.Add(ranDomvar.name);
                lastUnit_count++;
                break;
            case 1:
                ranDomvar = collum_Group3[Random.Range(0, collum_Group3.Count)];
                access.G_set.Add(ranDomvar.name);
                lastUnit_count++;
                break;
            case 2:
                ranDomvar = collum_Group4[Random.Range(0, collum_Group4.Count)];
                access.G_set.Add(ranDomvar.name);
                lastUnit_count++;
                break;
            case 3:
                ranDomvar = collum_Group5[Random.Range(0, collum_Group5.Count)];
                access.G_set.Add(ranDomvar.name);
                lastUnit_count = 0;
                break;
        }
    }
}
