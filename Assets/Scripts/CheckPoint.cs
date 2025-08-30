using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public Text UIText = null;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        {
            UIText.text = "Checkpoint Reached!";
            
        }
    }
}
