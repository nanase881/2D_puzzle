using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    int finalScore;
    public Text finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = CountScore.ReturnScore();
        finalScoreText.text = finalScore.ToString();
    }
}
