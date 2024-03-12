using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public  PlayerManager playerManager;
    void OnTriggerEnter()
    {
        playerManager.CompleteLevel();
    }
    
}
