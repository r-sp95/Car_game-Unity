using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public string[] Messages; //1, 2 and 3
    public float Interval = 1f;
    private Text UIText = null;
    public Rigidbody CarBody = null;

    public IEnumerator Start()
    {
        UIText = GetComponent<Text>();
        CarBody.isKinematic = true;

        int MessageDisplay = Messages.Length - 1;

        while (MessageDisplay >= 0)
        {
            //print(Messages[MessageDisplay]);
            UIText.text = Messages[MessageDisplay];
            print(Messages[MessageDisplay]);
            yield return new WaitForSeconds(Interval);
            MessageDisplay -= 1;
        }
        CarBody.isKinematic = false;
    }
}
