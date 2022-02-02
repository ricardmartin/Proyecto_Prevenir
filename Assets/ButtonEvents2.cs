using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents2 : MonoBehaviour
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
                audioClip = Resources.Load<AudioClip>("Sounds/dau");
                PlayMusic();
                break;
            case 1:
                audioClip = Resources.Load<AudioClip>("Sounds/boca");
                PlayMusic();

                break;
            case 2:
                audioClip = Resources.Load<AudioClip>("Sounds/ola");
                PlayMusic();

                break;
            case 3:
                audioClip = Resources.Load<AudioClip>("Sounds/ala");
                PlayMusic();

                break;
            case 4:
                audioClip = Resources.Load<AudioClip>("Sounds/arbre");
                PlayMusic();

                break;
            case 5:
                audioClip = Resources.Load<AudioClip>("Sounds/fulla");
                PlayMusic();

                break;
            case 6:
                audioClip = Resources.Load<AudioClip>("Sounds/mantel");
                PlayMusic();

                break;
            case 7:
                audioClip = Resources.Load<AudioClip>("Sounds/lluna");
                PlayMusic();

                break;
            case 8:
                audioClip = Resources.Load<AudioClip>("Sounds/mantel");
                PlayMusic();

                break;
            case 9:
                audioClip = Resources.Load<AudioClip>("Sounds/pilota");
                PlayMusic();

                break;
            case 10:
                audioClip = Resources.Load<AudioClip>("Sounds/llavis");
                PlayMusic();

                break;
            case 11:
                audioClip = Resources.Load<AudioClip>("Sounds/muntanya");

                PlayMusic();

                break;

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
