using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_ma1 : MonoBehaviour
{
    public GameObject set;
    void Start()
    {
        set = GameObject.FindWithTag("refPos");
    }
    void Update()
    {
        transform.position = set.transform.position;
    }
}
