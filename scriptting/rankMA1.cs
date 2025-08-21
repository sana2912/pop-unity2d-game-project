using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Newtonsoft.Json;
using System;
public class rankMA1 : MonoBehaviour
{
    public GameObject getVAR;
    public main_manageMent1 access;
    public int rank;
    public TMP_Text lavel;
    public string rankDATA;

    void Start()
    {
        access = getVAR.GetComponent<main_manageMent1>();
        loadData();
    }
    void Update()
    {
        lavel.text = rank + " rank";
        if (access.lavelNumBer > rank)
        {
            rank = access.lavelNumBer;
            Savelavels();
        }
        /*
        if (Input.GetButtonDown("clear"))
        {
            try
            {
                PlayerPrefs.DeleteKey("rankDATA");
                PlayerPrefs.Save();
            }
            catch (Exception massage)
            {
                Debug.LogErrorFormat("data can not remove" + massage);
            }
        */
    }
    public void Savelavels()
    {
        try
        {
            Debug.Log("saving systems winking");
            string json = JsonConvert.SerializeObject(rank);
            PlayerPrefs.SetString("rankDATA",json);
            PlayerPrefs.Save();
        }
        catch (Exception massage)
        {
            Debug.LogErrorFormat("data can not save"+ massage);
        }
    }
    public void loadData()
    {
        try
        {
            string json = PlayerPrefs.GetString("rankDATA");
            rank = JsonConvert.DeserializeObject<int>(json);
        }
        catch(Exception massage)
        {
            Debug.LogError("data can not load" + massage);
        }
    }
}
