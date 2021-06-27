using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField] private Transform camTransform;

    void Update()
    {
        transform.rotation = camTransform.rotation;
    }
}
