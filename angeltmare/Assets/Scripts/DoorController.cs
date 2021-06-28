using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public List<Transform> doorModel;
    public List<GameObject> colObject;

    public float openSpeed;


    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    private void OpenDoor(){
        if(PlayerController.diceInHand==true && Input.GetMouseButton(0))
        switch(PlayerController.diceNumber){
            case 1:
            Debug.Log("Puerta 1 abierta");
            doorModel[0].position = Vector3.MoveTowards(doorModel[0].position, new Vector3(doorModel[0].position.x,doorModel[0].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[0].position.z == -1.55f){
                colObject[0].SetActive(false);
            }
                break;
            case 2:
            Debug.Log("Puerta 2 abierta");
            doorModel[1].position = Vector3.MoveTowards(doorModel[1].position, new Vector3(doorModel[1].position.x,doorModel[1].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[1].position.z == -1.55f){
                colObject[1].SetActive(false);
            }
                break;
            case 3:
            Debug.Log("Puerta 3 abierta");
            doorModel[2].position = Vector3.MoveTowards(doorModel[2].position, new Vector3(doorModel[2].position.x,doorModel[2].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[2].position.z == -1.55f){
                colObject[2].SetActive(false);
            }
                break;
            case 4:
            Debug.Log("Puerta 4 abierta");
            doorModel[3].position = Vector3.MoveTowards(doorModel[3].position, new Vector3(doorModel[3].position.x,doorModel[3].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[3].position.z == -1.55f){
                colObject[3].SetActive(false);
            }
                break;
            case 5:
            Debug.Log("Puerta 5 abierta");
            doorModel[4].position = Vector3.MoveTowards(doorModel[4].position, new Vector3(doorModel[4].position.x,doorModel[4].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[4].position.z == -1.55f){
                colObject[4].SetActive(false);
            }
                break;
            case 6:
            Debug.Log("Puerta 6 abierta");
            doorModel[5].position = Vector3.MoveTowards(doorModel[5].position, new Vector3(doorModel[5].position.x,doorModel[5].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[5].position.z == -1.55f){
                colObject[5].SetActive(false);
            }
                break;
            case 7:
            Debug.Log("Puerta 7 abierta");
            doorModel[6].position = Vector3.MoveTowards(doorModel[6].position, new Vector3(doorModel[6].position.x,doorModel[6].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[6].position.z == -1.55f){
                colObject[6].SetActive(false);
            }
                break;
            case 8:
            Debug.Log("Puerta 8 abierta");
            doorModel[7].position = Vector3.MoveTowards(doorModel[7].position, new Vector3(doorModel[7].position.x,doorModel[7].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[7].position.z == -1.55f){
                colObject[7].SetActive(false);
            }
                break;
            case 9:
            Debug.Log("Puerta 9 abierta");
            doorModel[8].position = Vector3.MoveTowards(doorModel[8].position, new Vector3(doorModel[8].position.x,doorModel[8].position.y, -1.55f), openSpeed * Time.deltaTime);
            if(doorModel[8].position.z == -1.55f){
                colObject[8].SetActive(false);
            }
                break;
        }
        
    }
}
