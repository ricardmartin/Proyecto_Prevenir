using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueFinal : MonoBehaviour
{
    private AudioClip audioClip;
    private AudioSource audio;
    public int numDialogue;
    public string[] dialogues;
    public string[] sounds;
    public GameObject objectText;
    public GameObject master;
  
    public GameObject canvasObject;
    private UnityEngine.UI.Text text;
    private void PlayMusic()
    {
        audio = gameObject.GetComponent<AudioSource>();

        audio.clip = audioClip;
        audio.Play();

    }
    // Start is called before the first frame update
    void Start()
    {
        canvasObject = GameObject.FindGameObjectWithTag("Canvas");
        text = objectText.GetComponent<UnityEngine.UI.Text>();
        StartCoroutine(dialogue());
    }
    IEnumerator dialogue()
    {
      
            text.text = dialogues[0];
            audioClip = Resources.Load<AudioClip>(sounds[0]);
            PlayMusic();
            yield return new WaitForSeconds(7);

        
        Application.Quit();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
