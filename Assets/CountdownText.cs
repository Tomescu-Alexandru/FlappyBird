using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CountdownText : MonoBehaviour
{
    // Start is called before the first frame update
    Text countDown;
    public delegate void CountdownFinished();
    public static event CountdownFinished OnCountDownFinished;

    void OnEnable()
    {
        countDown = GetComponent<Text>();
        countDown.text = "3";
        StartCoroutine("Countdown");
    }

    IEnumerator Countdown()
    {
        int count = 3;
        for(int i =0; i < count; i++)
        {
            countDown.text = (count - i).ToString();
            yield return new WaitForSeconds(1);
        }

        OnCountDownFinished();
    }
}
