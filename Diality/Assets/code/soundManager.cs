using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static AudioClip BackGround, tomHot, tomCold, tomRelax;
    static AudioSource audioSrc;
    void Start()
    {
        tomHot = Resources.Load<AudioClip>("Hot1");
        tomCold = Resources.Load<AudioClip>("Cold1");
        tomRelax = Resources.Load<AudioClip>("Sigh1");
        BackGround = Resources.Load<AudioClip>("BackGround");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //audioSrc.Play() public void playBackGround()
    }

    public static void PlaySound(string clip)
    {
        switch (clip) {
        case "hot":
             audioSrc.PlayOneShot(tomHot);
             break;
        case "cold":
                audioSrc.PlayOneShot(tomCold);
            break;
        case "relax":
            audioSrc.PlayOneShot(tomRelax);
            break;
        }
    }
}
