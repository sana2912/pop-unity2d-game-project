using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanagement : MonoBehaviour
{
    public GameObject getUIscene;
    private List<string> names = new List<string>() { "redBall", "blueskyball", "purpleBall", "yellowBall", "greenBall", "brightBlueBall", "pinkBall" };
    private bool pauseClicked;
    private bool resumeClicked;
    private bool quiteClick;
    public AudioSource clickEffect;
    public void pauseButton()
    {
        if (!pauseClicked)
        {
            clickEffect.Play();
            pauseClicked = true;
            getUIscene.SetActive(true);
            resumeClicked = false;
            Time.timeScale = 0f;
        }
    }
    public void resumeButton()
    {
        if (!resumeClicked)
        {
            clickEffect.Play();
            resumeClicked = true;
            Time.timeScale = 1f;
            pauseClicked = false;
            getUIscene.SetActive(false);
        }
    }
    public void quiteButton()
    {
        if (!quiteClick)
        {
            quiteClick = true;
            SceneManager.LoadScene(0);
        }
    }
}
