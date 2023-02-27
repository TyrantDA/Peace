using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordID : MonoBehaviour
{
    // Start is called before the first frame update
    public int ID;
    public AudioSource crunch;
    private bool play;
    
    void Start()
    {
        play = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(play)
        {
            crunch.Play();
            play = false;
        }
    }

    public void setID(int apply)
    {
        ID = apply;
    }

    public int getID()
    {
        return ID;
    }

    public void SetCrunch(AudioSource hold)
    {
        crunch = hold;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FlagObject") && PlayerPrefs.GetInt("OnOff",0) == 0)
        {
            play = true;
        }
        if (collision.gameObject.CompareTag("Base") && PlayerPrefs.GetInt("OnOff", 0) == 0)
        {
            play = true;
        }
    }
}
