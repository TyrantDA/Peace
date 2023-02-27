using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudCounter : MonoBehaviour
{
    // playerprefs
    public Kill killcounter;
    public PointTotal pointsCounter;
    public Text input;
    public Text score;
    public LevelEnd end;

    private int count;
    private int endRequirements;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        endRequirements = end.numberOfDrops;


        input.text = " " + count + " ";


        score.text = " " + endRequirements + " ";
    }

    // Update is called once per frame
    void Update()
    {
        count = endRequirements - killcounter.GetKillCount();
        input.text = " " + count + " ";

        count = pointsCounter.GetPoints();
        score.text = " " + count + " ";
    }
}
