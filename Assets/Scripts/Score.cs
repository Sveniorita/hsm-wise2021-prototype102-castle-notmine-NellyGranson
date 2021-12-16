using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Dieses Script beschreibt, dass der Score hoch geht ,
// wenn eine Münze gesammelt wird.
// Achtung! Das Script liegt auf dem Player, nicht der Münze!

public class Score : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum;
    public AudioSource CoinSFX;
    public ParticleSystem playParticleSystem;

    void Start()
    {
        scoreNum = 0;
        myScoreText.text = ("Score: " + scoreNum);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if(col.tag == "MyCoin")
        {
            scoreNum += 1;
            playParticleSystem = GetComponent<ParticleSystem>();
            playParticleSystem.Play();
            Destroy(col.gameObject);
            myScoreText.text = ("Score: " + scoreNum);
            CoinSFX = GetComponent<AudioSource>();
            CoinSFX.Play(); 
            
        }
    }

}
