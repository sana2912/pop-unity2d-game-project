using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorMa1 : MonoBehaviour
{
    public GameObject getVAR;
    private main_manageMent1 access_VAR;
    private List<string> colors = new List<string>() { "redBall", "blueskyball", "purpleBall", "yellowBall", "greenBall", "brightBlueBall", "pinkBall" };
    public List<string> Activecolors = new List<string>() {};
    public bool massage;

    public SpriteRenderer iCon_renderer; 
    public Sprite m_sprite1;
    public Sprite m_sprite2;
    public Sprite m_sprite3;
    public Sprite m_sprite4;
    public Sprite m_sprite5;
    public Sprite m_sprite6;
    public Sprite m_sprite7;

    void Start()
    {
        access_VAR = getVAR.GetComponent<main_manageMent1>();
        iCon_renderer = gameObject.GetComponent<SpriteRenderer>();
        InvokeRepeating("Seting", 1.0f, 2.0f);   
    }
    void Update()
    {
        if (massage && Activecolors.Count == 0)
        {
            findactive();
            if (Activecolors.Count !=  0)
            {
                access_VAR.getColor = Activecolors[Random.Range(0, Activecolors.Count)];
                switch (access_VAR.getColor)
                {
                    case "redBall": iCon_renderer.sprite = m_sprite1;  massage = false; Activecolors.Clear(); break;
                    case "blueskyball": iCon_renderer.sprite = m_sprite2; massage = false; Activecolors.Clear(); break;
                    case "purpleBall": iCon_renderer.sprite = m_sprite3; massage = false; Activecolors.Clear(); break;
                    case "yellowBall": iCon_renderer.sprite = m_sprite4; massage = false; Activecolors.Clear(); break;
                    case "greenBall": iCon_renderer.sprite = m_sprite5; massage = false ;Activecolors.Clear(); break;
                    case "brightBlueBall": iCon_renderer.sprite = m_sprite6; massage = false; Activecolors.Clear(); break;
                    case "pinkBall": iCon_renderer.sprite = m_sprite7; massage = false; Activecolors.Clear(); break;
                }
            }
        }
    }
    void Seting(){massage = true;}
    void findactive()
    {
        for (int i = 0; i < colors.Count; i++)
        {
            string name = (colors[i]);
            List<GameObject> ActivecHeck = new List<GameObject>(GameObject.FindGameObjectsWithTag(name));
            if (ActivecHeck.Count != 0)
            {
                Activecolors.Add(colors[i]);
                ActivecHeck.Clear();
            }
        }
    }
}

