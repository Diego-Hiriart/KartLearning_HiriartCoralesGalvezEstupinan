using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostingCollider : MonoBehaviour
{
    [SerializeField] GhostManager ghostManager;

    int count = 0;

    void OnTriggerExit(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            count++;
            Debug.Log(count);
            if(count != 1)
            {
                ghostManager.playing = true;
                ghostManager.recording = true;
            }
        }     
    }
}
