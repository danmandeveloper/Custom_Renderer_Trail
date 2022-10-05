using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Very_Important : MonoBehaviour
{
    [SerializeField]
    private LineRenderer lRenderer;
    [SerializeField]
    private Transform targetA, targetB;
    [Range(2, 100)]
    [SerializeField]
    private int lineRes = 2;
    [SerializeField]
    private AnimationCurve curvy;
    private Vector3 desiredPosition;

    private void Start()
    {
        lRenderer = GetComponent<LineRenderer>();
    }
    void Update()
    {
        if (lRenderer.positionCount != lineRes)
        {
            lRenderer.positionCount = lineRes;
        }
        for (int x = 0; x < lRenderer.positionCount; x++)
        {
            desiredPosition = Vector3.Lerp(targetA.position, targetB.position, x / (float)lRenderer.positionCount);
            lRenderer.SetPosition(x, new Vector3(desiredPosition.x, desiredPosition.y + curvy.Evaluate(x / (float)lRenderer.positionCount), desiredPosition.z));

            if (x >= lRenderer.positionCount - 1)
            {
                desiredPosition = Vector3.Lerp(targetA.position, targetB.position, 1);
                lRenderer.SetPosition(x, new Vector3(desiredPosition.x, desiredPosition.y + curvy.Evaluate(x / (float)lRenderer.positionCount), desiredPosition.z));
            }
        }
    }
}
