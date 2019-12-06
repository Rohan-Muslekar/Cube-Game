using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Start()
    {
        score.text = "SCORE";
    }
    void Update()
    {   
        score.text = "SCORE\n" + "\t" + player.position.z.ToString("0");
    }
}
