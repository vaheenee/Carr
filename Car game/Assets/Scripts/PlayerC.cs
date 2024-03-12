using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerC : MonoBehaviour
{
    private CharacterController controller;
    void Start()
    {
    controller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
     void Update()
    {
       controller.center=controller.center;
        
    }
     private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Obstacle")
        {
            PlayerManager.gameOver = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        PlayerManager.gameOver = true;
    }

}