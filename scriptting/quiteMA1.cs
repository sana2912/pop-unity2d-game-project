using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiteMA1 : MonoBehaviour
{
    public GameObject getPos;

    void Update()
    {
        transform.position = getPos.transform.position;
    }
}
