using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_ki_mummy : MonoBehaviour
{
    public float scrollSpeed;
    Vector3 initPos;

    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >(initPos + new Vector3(0, -20f, 0)).y)
            transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        else 
            transform.position = initPos;
    }
}
