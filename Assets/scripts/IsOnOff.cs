using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsOnOff : MonoBehaviour
{
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("OnOff", 0) == 0)
        {
            buttonText.text = "Turn off collision \n Sound effect";
        }
        else if (PlayerPrefs.GetInt("OnOff", 0) == 1)
        {
            buttonText.text = "Turn on collision \n Sound effect";
        }
    }
}
