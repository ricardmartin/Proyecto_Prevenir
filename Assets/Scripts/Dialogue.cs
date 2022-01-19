using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    private AudioClip audioClip;
    private AudioSource audio;
    public int numDialogue;
    public string[] dialogues;
    public string[] sounds;
    public GameObject objectText;
    public GameObject master;
    public GameObject nextMinigame;
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
        for (int i = 0; i < numDialogue; i++)
        {
            text.text = dialogues[i];
            audioClip = Resources.Load<AudioClip>(sounds[i]);
            PlayMusic();
            yield return new WaitForSeconds(audioClip.length);

        }
        GameObject newObject = Instantiate(nextMinigame,new Vector3(0,0,0), Quaternion.identity);
        newObject.transform.SetParent(canvasObject.transform, false);

        newObject.transform.localScale = new Vector3(1, 1, 1);
        Destroy(master);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
