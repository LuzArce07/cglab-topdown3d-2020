using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class GameAudio
{
    
    [SerializeField]
    AudioClip background;

    [SerializeField]
    AudioClip battle;

    AudioSource audioSource;

    public AudioSource AudioSource { get => audioSource; set => audioSource = value; }

    public void PlayAudio(AudioClip audioClip)
    {

        if(!ClipsEqual(audioClip))
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        
    }

    public void PlayBGMusic()
    {
        PlayAudio(background);
    }

    public void PlayBattleMusic()
    {
        PlayAudio(battle);
    }

    bool ClipsEqual(AudioClip clip)
    {
        return clip == audioSource.clip;
    }

}
