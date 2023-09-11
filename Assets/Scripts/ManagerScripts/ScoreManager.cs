using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    private int score;
    private int combo;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        combo = 0;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    public void AddScore(int num)
    {
        score += num;
    }

    public void DecScore(int num)
    {
        score -= num;
    }

    public void AddCombo()
    {
        combo++;
    }

    public int GetScore()
    {
        return score;
    }

}
