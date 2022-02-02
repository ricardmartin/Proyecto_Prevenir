using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Feedback : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _btn1;
    private Button _button1;
    public GameObject _btn2;
    private Button _button2;
    private AudioSource audio;
    private AudioSource audioIncorrect;

    public GameObject _btn3;
    private Button _button3;
    public AudioClip audioClip;
    public AudioClip audioClip2;

    public Text _txtFeedback;
    public int _Contador = 0;
    private int _noRimaNum = 2;
    public GameObject[] ingredientes;
    public GameObject master;
    public GameObject nextMinigame;
    private GameObject canvasObject;
    private string[] palabrasIncorrectes;
    int fraseIncorrecta = 0;
    public GameObject[] corrects;
    public GameObject[] incorrects;

    private bool mouse_over = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("ENTRAMOS");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("SALIMOS");

    }
    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);

        //Do the action after the delay time has finished.
    }
    void Start()
    {
        audioIncorrect = this.gameObject.AddComponent<AudioSource>();
        palabrasIncorrectes = new string[4] { "Sounds/provadenou", "Sounds/intentahounaltrecop", "Sounds/estassegur", "Sounds/joagafaria" };
        canvasObject = GameObject.FindGameObjectWithTag("Canvas");
        Debug.Log("DALE");
        _button1 = _btn1.GetComponent<Button>();
        _button1.onClick.AddListener(() =>
        {
            if (_noRimaNum == 1)
            {

                Debug.Log("Correcta 1");
                _txtFeedback.text = "Correcte";


                StartCoroutine(newImages());


                //_txtFeedback.text = _Contador.ToString();

            }
            else
            {
                fraseIncorrecta = Random.Range(0, 4);
                audioClip2 = Resources.Load<AudioClip>(palabrasIncorrectes[fraseIncorrecta]); ;

                PlayIncorrect();
                StartCoroutine(incorrect(0));

            }

        });
        _button2 = _btn2.GetComponent<Button>();
        _button2.onClick.AddListener(() =>
        {
            if (_noRimaNum == 2)
            {
                _txtFeedback.text = "Correcte";
                Debug.Log("Entramosss");

                StartCoroutine(newImages());
              
                   
                

                
                //_txtFeedback.text = _Contador.ToString();

            }
            else
            {
                fraseIncorrecta = Random.Range(0, 4);
                audioClip2 = Resources.Load<AudioClip>(palabrasIncorrectes[fraseIncorrecta]); ;

                PlayIncorrect();
                StartCoroutine(incorrect(1));

            }

        });

        _button3 = _btn3.GetComponent<Button>();
        _button3.onClick.AddListener(() =>
        {
            if (_noRimaNum == 3)
            {
                _txtFeedback.text = "Correcte";


                StartCoroutine(newImages());


               // _txtFeedback.text = _Contador.ToString();

            }
            else
            {
                fraseIncorrecta = Random.Range(0, 4);
                audioClip2 = Resources.Load<AudioClip>(palabrasIncorrectes[fraseIncorrecta]); ;

                PlayIncorrect();
                StartCoroutine(incorrect(2));


            }

        });
        StartCoroutine(firstWords());

    }
    private void  PlayMusic()
    {
         audio = gameObject.GetComponent<AudioSource>();


        audio.clip = audioClip;
        audio.Play();

    }

    private void PlayIncorrect()
    {


        audioIncorrect.clip = audioClip2;
        audioIncorrect.Play();

    }
    IEnumerator firstWords()
    {
        _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
        _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
        _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
        audioClip = Resources.Load<AudioClip>("Sounds/sol");

        PlayMusic();

        _button1.image.sprite = Resources.Load<Sprite>("Sprites/sol");

        yield return new WaitForSeconds(audioClip.length);
        audioClip = Resources.Load<AudioClip>("Sounds/dau");

        PlayMusic();

        _button2.image.sprite = Resources.Load<Sprite>("Sprites/dau");
        yield return new WaitForSeconds(audioClip.length);
        audioClip = Resources.Load<AudioClip>("Sounds/cargol");

        PlayMusic();

        _button3.image.sprite = Resources.Load<Sprite>("Sprites/cargol");
        yield return null;

    }
    IEnumerator incorrect(int aux)
    {
        incorrects[aux].SetActive(true);

        yield return new WaitForSeconds(2);
        incorrects[aux].SetActive(false);
        yield return null;

    }
    IEnumerator newImages()
    {
        audioClip = Resources.Load<AudioClip>("Sounds/tick1");
        PlayMusic();
        if (_noRimaNum == 1)
        {
            corrects[0].SetActive(true);
            yield return new WaitForSeconds(2);
        }
        if (_noRimaNum == 2)
        {
            corrects[1].SetActive(true);
            yield return new WaitForSeconds(2);
        }
        if (_noRimaNum == 3)
        {
            corrects[2].SetActive(true);
            yield return new WaitForSeconds(2);
        }
        corrects[0].SetActive(false);
        corrects[1].SetActive(false);
        corrects[2].SetActive(false);


        switch (_Contador)
        {
            case 0:
                ingredientes[0].SetActive(true);

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                
                audioClip = Resources.Load<AudioClip>("Sounds/oca");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/oca");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/boca");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/boca");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/peu");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/peu");
                _noRimaNum = 3;

                _Contador++;
                yield return null;
                break;
            case 1:
                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/gat");
                PlayMusic();


                _button1.image.sprite = Resources.Load<Sprite>("Sprites/gat");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/ola");
                PlayMusic();


                _button2.image.sprite = Resources.Load<Sprite>("Sprites/ola");

                yield return new WaitForSeconds(audioClip.length);

                audioClip = Resources.Load<AudioClip>("Sounds/farola");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/farola");

                _noRimaNum = 1;

                _Contador++;
                yield return null;

                break;
            case 2:
                ingredientes[1].SetActive(true);

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/pera");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/pera");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/ala");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/ala");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/pala");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                _Contador++;
                _noRimaNum = 1;
                yield return null;

                break;
            case 3:
                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/llibre");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/llibre");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/arbre");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/arbre");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/collar");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/collar");
                _Contador++;
                _noRimaNum = 3;
                yield return null;

                break;
            case 4:
                ingredientes[2].SetActive(true);

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/sabo");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/sabo");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/fulla");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/fulla");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/camio");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/camio");
                _Contador++;
                _noRimaNum = 2;
                yield return null;

                break;

            case 5:
                ingredientes[3].SetActive(true);

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/hotel");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/hotel");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/mantel");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/mantel");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/llibre");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/llibre");
                _Contador++;
                _noRimaNum = 3;
                yield return null;

                break;



            case 6:
                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/cuna");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/cuna");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/lluna");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/lluna");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/ocell");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/ocell");
                _Contador++;
                _noRimaNum = 3;
                yield return null;

                break;
            case 7:

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/pera");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/pera");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/mantel");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/mantel");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/bandera");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/bandera");
                _Contador++;
                _noRimaNum = 2;
                yield return null;

                break;
            case 8:
                ingredientes[4].SetActive(true);

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/mapa");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/mapa");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/pilota");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/pilota");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/patata");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                _Contador++;
                _noRimaNum = 1;
                yield return null;

                break;
            case 9:
                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/mussol");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/mussol");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/llavis");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/llavis");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/llapis");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/llapis");
                _Contador++;
                _noRimaNum = 1;
                yield return null;

                break;
            case 10:
                ingredientes[5].SetActive(true);

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button2.image.sprite = Resources.Load<Sprite>("Sprites/transparant");
                _button3.image.sprite = Resources.Load<Sprite>("Sprites/transparant");

                audioClip = Resources.Load<AudioClip>("Sounds/aranya");

                PlayMusic();

                _button1.image.sprite = Resources.Load<Sprite>("Sprites/aranya");

                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/muntanya");

                PlayMusic();

                _button2.image.sprite = Resources.Load<Sprite>("Sprites/muntanya");
                yield return new WaitForSeconds(audioClip.length);
                audioClip = Resources.Load<AudioClip>("Sounds/pastis");

                PlayMusic();

                _button3.image.sprite = Resources.Load<Sprite>("Sprites/pastis");
                _Contador++;
                _noRimaNum = 3;
                yield return null;

                break;
            case 11:
                Debug.Log("Cambio escena");
                GameObject newObject = Instantiate(nextMinigame, new Vector3(0, 0, 0), Quaternion.identity);
                newObject.transform.SetParent(canvasObject.transform, false);

                newObject.transform.localScale = new Vector3(1, 1, 1);
                Destroy(master);


              
                break;
            default:
                break;
        }

        yield return null;
    }
    
}
