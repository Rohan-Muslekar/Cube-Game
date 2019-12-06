using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GMScript gm;

    void OnTriggerEnter()
    
    {
        gm.CompleteLevel(); 
    }
}
