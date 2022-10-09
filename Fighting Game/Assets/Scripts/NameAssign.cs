using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameAssign : MonoBehaviour
{
    public TMPro.TextMeshProUGUI P1Namee, P2Namee;
    void Start()
    {
        P1Namee.GetComponent<TMPro.TextMeshProUGUI>().text = Gamehandler.P1Name + "";
        P2Namee.GetComponent<TMPro.TextMeshProUGUI>().text = Gamehandler.P2Name + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
