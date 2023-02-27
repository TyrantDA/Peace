using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public GameObject colObject;
    public HoldList list;
    public AudioSource explode;

    private int killCount;
    // Start is called before the first frame update
    void Start()
    {
        killCount = 0;
    }

    public int GetKillCount()
    {
        return killCount;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("FlagObject"))
        {
            colObject = col.transform.gameObject;
            list.RemoveObj(colObject.GetComponent<RecordID>().getID());
            explode.Play();
            Destroy(colObject);
            killCount++;
        }
    }
}
