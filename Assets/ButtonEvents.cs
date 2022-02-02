using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{
    public GameObject gameManager;
    private AudioSource audio;
    public AudioClip audioClip;
    int numPalabra;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void PlayMusic()
    {
        audio = gameObject.GetComponent<AudioSource>();


        audio.clip = audioClip;
        audio.Play();

    }
    public void OnEnter()
    {
        switch (gameManager.GetComponent<Feedback>()._Contador)
        {
            case 0:
                audioClip = Resources.Load<AudioClip>("Sounds/sol");
                PlayMusic();
                break;
            case 1:
                audioClip = Resources.Load<AudioClip>("Sounds/oca");
                PlayMusic();

                break;
            case 2:
                audioClip = Resources.Load<AudioClip>("Sounds/gat");
                PlayMusic();

                break;
            case 3:
                audioClip = Resources.Load<AudioClip>("Sounds/pera");
                PlayMusic();

                break;
            case 4:
                audioClip = Resources.Load<AudioClip>("Sounds/llibre");
                PlayMusic();

                break;
            case 5:
                audioClip = Resources.Load<AudioClip>("Sounds/sabo");
                PlayMusic();

                break;
            case 6:
                audioClip = Resources.Load<AudioClip>("Sounds/hotel");
                PlayMusic();

                break;
            case 7:
                audioClip = Resources.Load<AudioClip>("Sounds/cuna");
                PlayMusic();

                break;
            case 8:
                audioClip = Resources.Load<AudioClip>("Sounds/pera");
                PlayMusic();

                break;
            case 9:
                audioClip = Resources.Load<AudioClip>("Sounds/mapa");
                PlayMusic();

                break;
            case 10:
                audioClip = Resources.Load<AudioClip>("Sounds/mussol");
                PlayMusic();

                break;
            case 11:
                audioClip = Resources.Load<AudioClip>("Sounds/aranya");

                PlayMusic();

                break;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
