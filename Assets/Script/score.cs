using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text Scoretext;
    public Text FinalScore;
    int MyScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    void Update()
    {
        Scoretext.text = MyScore.ToString();
        FinalScore.text = "Score:"+MyScore.ToString();
    }

    public  void AddScore(int score)
    {
        MyScore = MyScore + score;
    }
}
