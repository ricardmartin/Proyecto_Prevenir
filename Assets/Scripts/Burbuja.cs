using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Burbuja : MonoBehaviour
{
    private Image exterior;
    private Image interior;
    public bool correcta = false;
    private AudioClip clip;
    private AudioSource audio;
    private string[] imagenesCorrectas;
    private string[] palabrasCorrectas;

    public string[] imagenesIncorrectas;
    public string[] palabrasIncorrectas;
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localPosition = new Vector3(Random.Range(-850,850),700,0);
        this.transform.localScale = new Vector3(3,3,3);

        imagenesCorrectas = new string[11] { "Sprites/sal", "Sprites/sabata", "Sprites/sabo", "Sprites/selva", "Sprites/sindria", "Sprites/so", "Sprites/sobre", "Sprites/sol", "Sprites/sopa", "Sprites/suau", "Sprites/sucre" };
        palabrasCorrectas = new string[11] { "Sounds/sal", "Sounds/sabata", "Sounds/sabo", "Sounds/selva", "Sounds/sindria", "Sounds/so", "Sounds/sobre", "Sounds/sol", "Sounds/sopa", "Sounds/suau", "Sounds/sucre" };

        imagenesIncorrectas = new string[13] { "Sprites/aranya", "Sprites/gat", "Sprites/pilota", "Sprites/arbre", "Sprites/llapis", "Sprites/pera", "Sprites/lluna", "Sprites/llibre", "Sprites/dau", "Sprites/ocell", "Sprites/camio" , "Sprites/mussol", "Sprites/peu" };
        palabrasIncorrectas = new string[13] { "Sounds/aranya", "Sounds/gat", "Sounds/pilota", "Sounds/arbre", "Sounds/llapis", "Sounds/pera", "Sounds/lluna", "Sounds/llibre", "Sounds/dau", "Sounds/ocell", "Sounds/camio", "Sounds/mussol", "Sounds/peu" };

        GameObject ChildGameObject = this.transform.GetChild(0).gameObject;
        interior = ChildGameObject.GetComponent<Image>();

        float _tipoBurbuja = Random.Range(0.0f, 1.0f);
        if(_tipoBurbuja <0.5f)
        {
            this.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Burbuja2");

        }
        else
        {
            this.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Burbuja3");
        }

        float random = Random.Range(0.0f, 1.1f);
        if (random < 0.5f) { 
            correcta = true;
        }

        if (correcta)
        {
            initCorrectWord();
        }
        else
        {
            initIncorrectWord();
        }

    }
    private void PlayMusic()
    {
        audio = gameObject.GetComponent<AudioSource>();


        audio.clip = clip;
        audio.Play();

    }
    void initCorrectWord()
    {
        int random = Random.Range(0,10);
        interior.sprite = Resources.Load<Sprite>(imagenesCorrectas[random]);
        clip = Resources.Load<AudioClip>(palabrasCorrectas[random]);
        PlayMusic();


    }
    void initIncorrectWord()
    {
        int random = Random.Range(0, 12);
        interior.sprite = Resources.Load<Sprite>(imagenesIncorrectas[random]);
        clip = Resources.Load<AudioClip>(palabrasIncorrectas[random]);
        PlayMusic();


    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 10 * Time.deltaTime, transform.position.z);
        if(transform.position.y < -150.0f)
        {
            Destroy(gameObject);
        }
    }
}
