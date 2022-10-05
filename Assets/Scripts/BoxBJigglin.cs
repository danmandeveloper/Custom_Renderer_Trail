using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



public class BoxBJigglin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
        Vector3 newScale = transform.localScale;
        newScale.y *= 1.2f;            
        transform.localScale = newScale;
        
     
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
