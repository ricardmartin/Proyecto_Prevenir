using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents3 : MonoBehaviour
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
                audioClip = Resources.Load<AudioClip>("Sounds/cargol");
                PlayMusic();
                break;
            case 1:
                audioClip = Resources.Load<AudioClip>("Sounds/peu");
                PlayMusic();

                break;
            case 2:
                audioClip = Resources.Load<AudioClip>("Sounds/farola");
                PlayMusic();

                break;
            case 3:
                audioClip = Resources.Load<AudioClip>("Sounds/pala");
                PlayMusic();

                break;
            case 4:
                audioClip = Resources.Load<AudioClip>("Sounds/collar");
                PlayMusic();

                break;
            case 5:
                audioClip = Resources.Load<AudioClip>("Sounds/camio");
                PlayMusic();

                break;
            case 6:
                audioClip = Resources.Load<AudioClip>("Sounds/llibre");
                PlayMusic();

                break;
            case 7:
                audioClip = Resources.Load<AudioClip>("Sounds/ocell");
                PlayMusic();

                break;
            case 8:
                audioClip = Resources.Load<AudioClip>("Sounds/bandera");
                PlayMusic();

                break;
            case 9:
                audioClip = Resources.Load<AudioClip>("Sounds/patata");
                PlayMusic();

                break;
            case 10:
                audioClip = Resources.Load<AudioClip>("Sounds/llapis");
                PlayMusic();

                break;
            case 11:
                audioClip = Resources.Load<AudioClip>("Sounds/pastis");
                PlayMusic();

                break;

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
