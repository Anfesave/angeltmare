using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public float speed = 1.0f;
    public float amount = 1.0f;

    void Update()
    {
        float shake = Mathf.Sin(Time.time * speed) * amount;
        transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z + shake);        
    }
}
