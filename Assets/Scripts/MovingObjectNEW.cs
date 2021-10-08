using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectNEW : MonoBehaviour
{
    public bool isMoving = false;

    Vector3[] Positions = new Vector3[4];
    public Vector3 a,b,c;
    [SerializeField] float speed;

    //[SerializeField] Vector3 offset;

    int nextPosIndex;
    Vector3 NextPos;
    Vector3[] pos;

    // Start is called before the first frame update
    void Start()
    {
        Positions[0] = transform.position;
        Positions[1] = transform.position + a;
        Positions[2] = transform.position + b;
        Positions[3] = transform.position + c;

        NextPos = Positions[0];

    }

    // Update is called once per frame
    void Update()
    {
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
