using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipConver : MonoBehaviour
{
    public GameObject master;
    public GameObject nextMinigame;
    public GameObject canvasObject;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() =>
        {
            GameObject newObject = Instantiate(nextMinigame, new Vector3(0, 0, 0), Quaternion.identity);
            newObject.transform.SetParent(canvasObject.transform, false);

            newObject.transform.localScale = new Vector3(1, 1, 1);
            Destroy(master);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
