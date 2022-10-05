using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public float offset, speed;
    public AnimationCurve height, movement;
    public Transform cubeA, cubeB;
    private float rate;
    private Vector3 desiredPosition;
    
    private void Update()
    {
        rate += Time.deltaTime * speed;

        desiredPosition = Vector3.Lerp(cubeA.position, cubeB.position, movement.Evaluate(rate));
        desiredPosition.y += height.Evaluate(rate) + offset;
        transform.position = desiredPosition;

        if (rate >= 1)
        {
            rate = 0;
            //desiredPosition = Vector3.Lerp(cubeB.position, cubeA.position, movement.Evaluate(rate));
            //desiredPosition.y += height.Evaluate(rate) + offset;
            //transform.position = desiredPosition;
        }
    }
}
