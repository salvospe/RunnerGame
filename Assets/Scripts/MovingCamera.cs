using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera: MonoBehaviour
{
    public bool isMoving = true;

    Vector3 start;

    [SerializeField] float speed;

    [SerializeField] Vector3 offset;

    Vector3 NextPos;

    void Start()
    {
        start = transform.position;
        NextPos = transform.position + offset;
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isMoving)
            MoveGameObject();
    }

    void MoveGameObject()
    {

        transform.position = Vector3.MoveTowards(transform.position, NextPos, speed * Time.deltaTime);

        if (transform.position == NextPos)
            transform.position = start;

    }

}
