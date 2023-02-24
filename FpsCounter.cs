using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    public Text FpsText;
    public TextMeshProUGUI FpsTMP;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;


    void Update()
    {
        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = "(" + frameRate.ToString() + " fps)";
            FpsTMP.text = "(" + frameRate.ToString() + " fps)";


            time -= pollingTime;
            frameCount = 0;
        }
    }
}
