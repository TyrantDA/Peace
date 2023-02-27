using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int PointAwarded;
    public Pickup pick;
    bool awardPoints;
    private int IDhold;
    public LayerMask groundLayers;
    public AudioSource points;

    private SpriteRenderer rend;
    private bool soundPlayed;
    // Start is called before the first frame update
    void Start()
    {
        awardPoints = false;
        rend = GetComponent<SpriteRenderer>();
        soundPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            IDhold = pick.getGameObject().GetComponent<RecordID>().getID();
        }
        catch
        {
            IDhold = -1;
        }

        // overlapBox
        //Collider2D targetObject = Physics2D.OverlapPoint(this.transform.position);
        Collider2D targetObject = Physics2D.OverlapBox(this.transform.position,this.transform.localScale, 0, groundLayers.value);
        if (targetObject.CompareTag("FlagObject"))
        {
            if (targetObject.gameObject.GetComponent<RecordID>().getID() != IDhold)
            {
                Debug.Log("check");
                awardPoints = true;
            }
        }
        else
        {
            awardPoints = false;
            soundPlayed = false;
        }

        if(awardPoints)
        {
            rend.color = Color.green;
        }
        else
        {
            rend.color = Color.red;
        }

        if(awardPoints && !soundPlayed)
        {
            points.Play();
            soundPlayed = true;
        }
    }

    public int GivePoints()
    {
        if(awardPoints)
        {
            return PointAwarded;
        }
        else 
        { 
            return 0; 
        }
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //if (other.CompareTag("FlagObject"))
        //{
        //    if (other.gameObject.GetComponent<RecordID>().getID() != IDhold)
        //    {
        //        Debug.Log("check");
        //        awardPoints = true;
        //    }
        //}
        //else
        //{
        //    awardPoints = false;
        //}
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("FlagObject"))
        //{
        //    if (other.gameObject.GetComponent<RecordID>().getID() != IDhold)
        //    {
        //        Debug.Log("check");
        //        awardPoints = true;
        //    }
        //}
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.CompareTag("FlagObject"))
        //{
        //    if (collision.gameObject.GetComponent<RecordID>().getID() != IDhold)
        //    {
        //            Debug.Log("check");
        //            awardPoints = false;
        //    }
        //}
    }
}