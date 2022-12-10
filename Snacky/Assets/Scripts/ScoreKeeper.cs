using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static float health = 100;
    public static float score = 0;
    public Text healthPer;

    private void Update()
    {
        healthPer.text = health.ToString();
    }
}
