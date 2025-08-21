using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homUI : MonoBehaviour
{
    public AudioSource getEFFECT;
    private Animator getAnimate;
    private bool state;

    private void Start()
    {
        getAnimate = GetComponent<Animator>();
        state = false;
    }

    public void playbutton()
    {
        if (!state)
        {
            state = true;
            getEFFECT.Play();
            getAnimate.Play("UIANI");
            StartCoroutine(load_scene());
        }
    }

    private IEnumerator load_scene()
    {
        yield return new WaitForSeconds(0.4f);
        state = false;
        SceneManager.LoadScene(1);

    }
}