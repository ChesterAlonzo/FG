using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement; 




public class Player2 : MonoBehaviour
{
    public VideoPlayer P2LowPunchVP, P2LowPunchMissVP, P2HighPunchVP, P2HighPunchMissVP, P2LowKickVP, P2LowKickMissVP, P2HighKickVP, P2HighKickMissVP, P2SpecialVP;
    
    public int p1hp = 100;
    public HealthBar healthbar;
    void Start()
    {
       healthbar.SetMaxHealth(p1hp); 
    }
    void Update()
    {
        
    }

    void dealDamage(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            P2LowPunchVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p1hp = currenthp -= 0;
            P2LowPunchMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage2(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            P2HighPunchVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p1hp = currenthp -= 0;
            P2HighPunchMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage3(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            P2LowKickVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p1hp = currenthp -= 0;
            P2LowKickMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage4(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            P2HighKickVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p1hp = currenthp -= 0;
            P2HighKickMissVP.GetComponent<VideoPlayer>().Play();
        }
    }

    void dealDamage5(int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            P2SpecialVP.GetComponent<VideoPlayer>().Play();
        }
        else
        {
            p1hp = currenthp -= damageAmount;
            P2SpecialVP.GetComponent<VideoPlayer>().Play();
        }
    }

    public void P2LowPunch()
    {
        dealDamage(p1hp,3,75);
        healthbar.SetHealth(p1hp);
        if (p1hp <= 0)
        {
            SceneManager. LoadScene ("Scene 6");
        }
    }

    public void P2HighPunch()
    {
        dealDamage2(p1hp,8,55);
        healthbar.SetHealth(p1hp);
        if (p1hp <= 0)
        {
            SceneManager. LoadScene ("Scene 6");
        }
    }
    public void P2LowKick()
    {
        dealDamage3(p1hp,6,65);
        healthbar.SetHealth(p1hp);
        if (p1hp <= 0)
        {
            SceneManager. LoadScene ("Scene 6");
        }
    }
    public void P2HighKick()
    {
        dealDamage4(p1hp,12,45);
        healthbar.SetHealth(p1hp);
        if (p1hp <= 0)
        {
            SceneManager. LoadScene ("Scene 6");
        }
    }
    public void P2Special()
    {
        dealDamage5(p1hp,25,100);
        healthbar.SetHealth(p1hp);
        if (p1hp <= 0)
        {
            SceneManager. LoadScene ("Scene 6");
        }
    }




























}
