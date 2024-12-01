using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Level theme");
        FindObjectOfType<AudioManager>().StopPlaying("Theme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
