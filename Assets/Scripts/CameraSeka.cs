using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeka : MonoBehaviour
{
    [SerializeField] private Transform targetToFallow;


    // Update is called once per frame
    void Update()
    {
        if (targetToFallow == null)
        {
            return;
        }

        
        transform.position = new Vector3(
            Mathf.Clamp(targetToFallow.position.x, -17f, 10f), 
            Mathf.Clamp(targetToFallow.position.y, -4f, 4f),
            transform.position.z
        );
    }
}
