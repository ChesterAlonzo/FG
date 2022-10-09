using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StanceLoop : MonoBehaviour
{
    public VideoPlayer LoopStance; 
    void Start()
    {
        LoopStance.GetComponent<VideoPlayer>().Play();
    }
    
    void Update()
    {
        LoopStance.GetComponent<VideoPlayer>().isLooping = true;
    }
}
