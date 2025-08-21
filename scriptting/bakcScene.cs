using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakcScene : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(setTo_unActive());
    }
    private IEnumerator setTo_unActive()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);    
    }
}
