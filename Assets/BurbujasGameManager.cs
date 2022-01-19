using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurbujasGameManager : MonoBehaviour
{
    public GameObject burbuja;
    private bool _gameCompleted = false;
    private AudioSource audio;
    private AudioClip audioClip;
    public AudioClip soundCorrect;
    public AudioClip soundError;
    public GameObject burbujitas;
    private AudioSource feedback;
    public GameObject master;
    public GameObject nextMinigame;
    private GameObject canvasObject;
    public GameObject dialogueMaster;
    int numOfCorrects = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateBubble());
        feedback = this.gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Comentarios()
    {
        audio = gameObject.GetComponent<AudioSource>();


        audio.clip = audioClip;
        audio.Play();

    }
    private void SoundCorrect()
    {
        feedback.clip = soundCorrect;
        feedback.Play();
    }
    private void SoundError()
    {
        feedback.clip = soundError;
        feedback.Play();
    }
    IEnumerator generateBubble()
    {
        while (!_gameCompleted)
        {
            // GameObject _burbuja = Instantiate(burbuja, new Vector3(Random.Range(400,1000), 700, 0), Quaternion.identity);
            GameObject _burbuja = Instantiate(burbuja, new Vector3(Random.Range(1100,1500) ,1300,0), Quaternion.identity);
            _burbuja.transform.parent = burbujitas.transform;            
            _burbuja.GetComponent<Button>().onClick.AddListener(() =>
            {
                if (_burbuja.GetComponent<Burbuja>().correcta)
                {
                    numOfCorrects++;
                    SoundCorrect();
                    switch (numOfCorrects)
                    {
                        case 1:
                            audioClip = Resources.Load<AudioClip>("Burbujas/moltbe");
                            Comentarios();
                            break;
                        case 3:
                            audioClip = Resources.Load<AudioClip>("Burbujas/hoestasfent");
                            Comentarios();


                            break;
                        case 5:
                            audioClip = Resources.Load<AudioClip>("Burbujas/quedalameitat");
                            Comentarios();

                            break;
                       
                        case 9:
                            audioClip = Resources.Load<AudioClip>("Burbujas/jahemquasiacabat");
                            Comentarios();


                            break;
                    }
                    if (numOfCorrects == 10)
                    {
                        dialogueMaster.gameObject.SetActive(true);
                        this.gameObject.SetActive(false);
                    }
                }
                else
                {
                    SoundError();
                }
               
                Destroy(_burbuja);

            });
            yield return new WaitForSecondsRealtime(4);
        }
    }
}
