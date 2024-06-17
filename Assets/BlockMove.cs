using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{

    public float moveTime;
    public float moveSpeed;

    private float moveCount;
    private float moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveCount = 0;
        moveDirection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        moveCount += Time.deltaTime;
        if (moveCount > moveTime)
        {
            moveCount = 0;
            moveDirection *= -1;
        }
        Vector3 newPosition=transform.position;
        newPosition.x += moveDirection * moveSpeed*Time.deltaTime;
        transform.position = newPosition;
    }
}
