using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class own_controllScript1 : MonoBehaviour
{
    public GameObject getPos;
    public GameObject getVar;
    public main_manageMent1 acessVAR;
    public GameObject getEf;
    public AudioSource effect;
    public AudioClip effect_1;
    public AudioClip effect_2;
    private bool state;
    public float ranNuB;
    Animator getAnimate;
    private bool played;
    void Start()
    {
        played = false;
        state = false;
        getAnimate = GetComponent<Animator>();
        int randomIndex = Random.Range(0, 3);
        float number1 = 0.4f;
        float number2 = 0.55f;
        float number3 = 0.7f;
        switch (randomIndex)
        {
            case 0:ranNuB = number1;break;
            case 1:ranNuB = number2;break;
            case 2:ranNuB = number3;break;
            default:ranNuB = number1;break;
        }
        getVar = GameObject.FindWithTag("GameController");
        getPos = GameObject.FindWithTag("refPos");
        getEf = GameObject.FindWithTag("effect2");
        effect = getEf.gameObject.GetComponent<AudioSource>();
        acessVAR = getVar.gameObject.GetComponent<main_manageMent1>();
    }
    private void Update()
    {
        if (transform.position.y > getPos.transform.position.y){Destroy(gameObject);}
    }
    void OnCollisionEnter2D(Collision2D hittingCol)
    {
        if (hittingCol.gameObject.CompareTag(gameObject.tag) && !played)
        {
            effect.clip = effect_2;
            getAnimate.Play("chr_animation");
            effect.Play();
            StartCoroutine(deleyDes());
            played = true;
        }
    }
    void PointerDown()
    {
        if (gameObject.CompareTag(acessVAR.getColor))
        {
            getAnimate.Play("chr_animation");
            state = true;
        }
    }
    void PointerUP()
    {
        if (state)
        {
            effect.clip = effect_1;
            effect.Play();
            state = false;
            if (acessVAR.action) { acessVAR.allow_ADD = true; }
            Destroy(gameObject);
        }
    }
    IEnumerator deleyDes()
    {
        yield return new WaitForSeconds(ranNuB);
        effect.clip = effect_1;
        Destroy(gameObject);
        effect.Play();
    }
}
