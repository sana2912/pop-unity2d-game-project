using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iconLoad : MonoBehaviour
{
    public GameObject getICONbutton;
    private void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(iconLOAD());
    }
    IEnumerator iconLOAD()
    {
        yield return new WaitForSeconds(1.0f);
        getICONbutton.SetActive(true);
    }
}
