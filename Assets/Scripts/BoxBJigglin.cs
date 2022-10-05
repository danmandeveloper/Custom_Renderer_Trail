using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;



public class BoxBJigglin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { 
        Vector3 newScale = transform.localScale;
        newScale.y *= 1.2f;            
        transform.localScale = newScale;
    }
    private void OnTriggerExit(Collider other)
    {
        transform.localScale = new Vector3(1, 1, 1); 
        
    }
}
