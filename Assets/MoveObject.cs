using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private GameObject[] cake;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        transform.TransformPoint(Vector3.zero);
        cake = GameObject.FindGameObjectsWithTag("Cake");
        //transform.localPosition = Vector3.zero;
        //transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cake[0].transform.position, speed * Time.deltaTime);

    }
}
