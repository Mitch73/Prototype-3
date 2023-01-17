using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public Vector3 starPos;

    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        starPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < starPos.x - repeatWidth)
        {
            transform.position = starPos;
        }
    }
}
