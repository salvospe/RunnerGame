using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public bool isMoving = false;

    Vector3[] Positions = new Vector3[2];
    [SerializeField] float speed;

    [SerializeField] Vector3 offset;

    int nextPosIndex;
    Vector3 NextPos;

    // Start is called before the first frame update
    void Start()
    {
        Positions[0] = transform.position;
        NextPos = Positions[0];
    }



    // Update is called once per frame
    void Update()
    {
        Positions[1] = Positions[0] + offset;
        if (isMoving)
            MoveGameObject();
    }

    void MoveGameObject()
    {
        if (transform.position == NextPos)
        {
            nextPosIndex++;
            if (nextPosIndex >= Positions.Length)
            {
                nextPosIndex = 0;
            }
            NextPos = Positions[nextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos, speed * Time.deltaTime);
        }
    }
}
