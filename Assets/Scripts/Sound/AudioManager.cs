using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField]Sound[] sounds;


    void Start()
    {
        foreach( Sound sound in sounds )
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.loop = sound.loop;

        }
    }

   public void playAudio(string name)
    {
        Sound sound = Array.Find(sounds, x => x.name == name);

        sound.source.Play();
    }
}
