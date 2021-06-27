using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicePickUp : MonoBehaviour
{
    //private static bool diceStatus = PlayerController.diceInHand;
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            PlayerController.diceInHand = true;
        }
        Destroy(gameObject);    
    }

    
}
