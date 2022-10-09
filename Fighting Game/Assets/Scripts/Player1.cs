using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement; 

public class Player1 : MonoBehaviour
{
    public VideoPlayer P1LowPunchVP, P1LowPunchMissVP, P1HighPunchVP, P1HighPunchMissVP, P1LowKickVP, P1LowKickMissVP, P1HighKickVP, P1HighKickMissVP, P1SpecialVP;
    public int p2hp = 100;
    public Button P1SPButton;
    public HealthBar healthbar;
    void Start()
    {
       healthbar.SetMaxHealth(p2hp);
    }
    void Update()
    {
        
    }

    void dealDamage(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p2hp = currenthp -= damageAmount;
            P1LowPunchVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p2hp = currenthp -= 0;
            P1LowPunchMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage2(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p2hp = currenthp -= damageAmount;
            P1HighPunchVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p2hp = currenthp -= 0;
            P1HighPunchMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage3(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p2hp = currenthp -= damageAmount;
            P1LowKickVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p2hp = currenthp -= 0;
            P1LowKickMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage4(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p2hp = currenthp -= damageAmount;
            P1HighKickVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p2hp = currenthp -= 0;
            P1HighKickMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage5(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p2hp = currenthp -= damageAmount;
            P1SpecialVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p2hp = currenthp -= damageAmount;
            P1SpecialVP.GetComponent<VideoPlayer>().Play();
        }
    }

    public void P1LowPunch()
    { 
        dealDamage(p2hp,3,75);
        healthbar.SetHealth(p2hp);
        if (p2hp <= 0)
        {
            SceneManager. LoadScene ("Scene 5");
        }
    }

    public void P1HighPunch()
    {
        dealDamage2(p2hp,8,55);
        healthbar.SetHealth(p2hp);
        if (p2hp <= 0)
        {
            SceneManager. LoadScene ("Scene 5");
        }
    }
    public void P1LowKick()
    {
        dealDamage3(p2hp,6,65);
        healthbar.SetHealth(p2hp);
        if (p2hp <= 0)
        {
            SceneManager. LoadScene ("Scene 5");
        }
    }
    public void P1HighKick()
    {
        dealDamage4(p2hp,12,45);
        healthbar.SetHealth(p2hp);
        if (p2hp <= 0)
        {
            SceneManager. LoadScene ("Scene 5");
        }
    }
    public void P1Special()
    {
        dealDamage5(p2hp,25,100);
        healthbar.SetHealth(p2hp);
        if (p2hp <= 0)
        {
            SceneManager. LoadScene ("Scene 5");
        }
    }

    public void button()
    {
        P1SPButton.interactable = false;
    }




























}
