using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyObject
{
    public GameObject obj;
    public bool hold;
    

    public MyObject(GameObject o, bool h)
    {
        obj = o;
        hold = h;
    }
}
public class HoldList : MonoBehaviour
{
    // Start is called before the first frame update
    private Dictionary<int,MyObject> hold;
    private int idCount;
    void Start()
    {
        hold = new Dictionary<int,MyObject>();
        idCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddObj(GameObject o, GameObject Spawn)
    {
        GameObject h = Instantiate(o, Spawn.transform.position, Quaternion.identity, Spawn.transform);
        bool h2 = false;
        int h3 = idCount;
        idCount++;

        h.GetComponent<RecordID>().setID(h3);
        h.GetComponent<RecordID>().SetCrunch(Spawn.GetComponent<GetCrunched>().GetCrunch());

        hold.Add(h3,new MyObject(h, h2));
    }

    public void RemoveObj(int i)
    {
        hold.Remove(i);
    }


}
