using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public Sprite handWhitDice;
    public Sprite hand;
    void Update()
    {
        changeImages();
    }

    public void changeImages(){
        if(PlayerController.diceInHand == true){
            GetComponent<Image>().sprite = handWhitDice;
        }else{
            GetComponent<Image>().sprite = hand;
        }
    }
}
