using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    public static bool diceInHand = false; 

    private List<int> list = new List<int>(){1,2,3,4,5,6,7,8,9,10};
    public static int diceNumber;

    void FixedUpdate()
    {
        ThrowDice();
    }

    private void ThrowDice(){
        if(diceInHand==true && Input.GetMouseButton(0)){
            diceInHand = false;
            Debug.Log("LANZA EL DADO: " + RollTheDice());
        }else{
            //No puede lanzar el dado
        }
        
    }

    private int RollTheDice(){
        int result = Random.Range(list[0],list.Last());
        list.RemoveAt(result -1);

        Debug.Log(System.String.Join("; ", list));
        return result;
    }
}
