using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Ball_Movement : MonoBehaviour
{
    [SerializeField]
    public int line;
    private LineRenderer lrenderer;
    private Vector3 compA, compB;
    private Vector3 desiredPosition;
    public float offset, speed;
    public AnimationCurve height, movement;
    public Transform cubeA, cubeB;
    private float rate;

    private void Start()
    {
        lrenderer = GetComponent<LineRenderer>();
        lrenderer.material.color = Color.black;
    }

    private void Update()
    {
       
        rate += Time.deltaTime * speed;

        desiredPosition = Vector3.Lerp(cubeA.position, cubeB.position, movement.Evaluate(rate));
        desiredPosition.y += height.Evaluate(rate) + offset;
        transform.position = desiredPosition;

        if (rate >= 1)
        {
            rate = 0;
        } 
        lrenderer.positionCount = line;
        compA = transform.position;
        for(int i = 0; i< line; i++)
        {
            compB = lrenderer.GetPosition(i);
            lrenderer.SetPosition(i, compA);
            compA = compB;
        }
    }
}
