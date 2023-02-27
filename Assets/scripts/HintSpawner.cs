using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintSpawner : MonoBehaviour
{
    public Text hint1;
    public Text hint2;
    public Text hint3;

    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DeathController.numberOfdeaths);
        if(DeathController.numberOfdeaths >= 1)
        {
            hint1.text = "A strong Base will last much longer \n than one that is rushed and narrow minded";
        }
        if(DeathController.numberOfdeaths >= 2)
        {
            Debug.Log("Hint2 play");
            hint2.text = "peace my not be force on two country \n try dropping them on the pile";
        }
        if(DeathController.numberOfdeaths >= 3)
        {
            hint3.text = "some may roll out of treaties \n try boxing them into agreement with other";
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        highScore.text = "HighScore : " + PlayerPrefs.GetInt("highScore", 0);
    }
}
