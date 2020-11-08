using UnityEngine;

public class Test : MonoBehaviour
{
    Transform tr;

    void Start() 
    { 
        tr = transform; 
    }

    void Update()
    {
        Debug.Log("Local=" + Vector3.right + " | Global=" + tr.TransformDirection(Vector3.right));
    }
}