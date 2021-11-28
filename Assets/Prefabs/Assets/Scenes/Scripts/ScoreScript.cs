using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Dieses Script beschreibt, dass der Score hoch geht ,
// wenn eine Münze gesammelt wird.

// Achtung! Das Script liegt auf dem Player, nicht der Münze!

public class ScoreScript : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum; 

    void Start()
    {

        scoreNum = 0;
        myScoreText.text = "scpre : " + scoreNum;


    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {

        if(Coin.tag == "MyCoin")
        {

            scoreNum += 1;
            Destroy(Coin.gameObject);
            myScoreText.text = "score" + scoreNum;

        }
        
    }


}
