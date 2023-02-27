using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnObjects : MonoBehaviour
{
    public GameObject Square;
    public GameObject CircleSmall;
    public GameObject Circle;
    public GameObject RectangleHorizonal;
    public GameObject RectangleVertical;
    public GameObject Triangle;

    public GameObject Rectangle3;
    public GameObject Rectangle4;
    public GameObject circle3;
    public GameObject Traingle2;
    public GameObject Nepal;

    public GameObject Spawn;

    public HoldList list;

    public AudioSource pop;

    private System.Random rnd;

    float currentTime;
    float minTimeBetweenSpawns;
    float maxTimeBetweenSpawns;
    // Start is called before the first frame update
    void Start()
    {
        rnd = new System.Random();
        minTimeBetweenSpawns = 1;
        maxTimeBetweenSpawns = 5;
        currentTime = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Debug.Log("fire");
            currentTime = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);


            //Debug.Log("spawn" + roll);
            int roll2 = rnd.Next(1, 7);
            //Debug.Log(roll2);

            if (roll2 == 6)
            {
                int roll3 = rnd.Next(1, 6);
                if (roll3 == 1)
                {
                    list.AddObj(CircleSmall,Spawn);
                    pop.Play();
                    //Instantiate(CircleSmall, Spawn.transform.position, Quaternion.identity, Spawn.transform);
                }
                else if (roll3 == 2)
                {
                    list.AddObj(Circle, Spawn);
                    pop.Play();
                    //Instantiate(Circle, Spawn.transform.position, Quaternion.identity, Spawn.transform);
                }
                else if(roll3 == 3)
                {
                    list.AddObj(Triangle, Spawn);
                    pop.Play();
                }
                else if(roll3 == 4)
                {
                    list.AddObj(Traingle2, Spawn);
                    pop.Play();
                }
                else if(roll3 == 5)
                {
                    list.AddObj(circle3, Spawn);
                    pop.Play();
                }
                else
                {
                    Debug.Log("error : " + roll3);
                }
            }
            else
            {
                int roll3 = rnd.Next(1, 7);
                if (roll3 == 1)
                {
                    list.AddObj(Square, Spawn);
                    pop.Play();
                    //Instantiate(Square, Spawn.transform.position, Quaternion.identity, Spawn.transform);
                }

                else if (roll3 == 2)
                {
                    list.AddObj(RectangleHorizonal, Spawn);
                    pop.Play();
                    //Instantiate(RectangleHorizonal, Spawn.transform.position, Quaternion.identity, Spawn.transform);
                }
                else if (roll3 == 3)
                {
                    list.AddObj(RectangleVertical, Spawn);
                    pop.Play();
                    //Instantiate(RectangleVertical, Spawn.transform.position, Quaternion.identity, Spawn.transform);
                }
                else if(roll3 == 4)
                {
                    list.AddObj(Rectangle3, Spawn);
                    pop.Play();
                }
                else if(roll3 == 5)
                {
                    list.AddObj(Rectangle4, Spawn);
                    pop.Play();
                }
                else if (roll3 == 6)
                {
                    list.AddObj(Nepal, Spawn);
                    pop.Play();
                }
                else
                {
                    Debug.Log("error: " + roll3);
                }
            }
        }
    }
}
