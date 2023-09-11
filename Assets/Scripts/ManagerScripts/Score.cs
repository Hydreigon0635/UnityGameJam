using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "SCORE: " +  ScoreManager.Instance.GetScore();
    }
}
