using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public Kill count;
    public int numberOfDrops;
    public PointTotal pt;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        int hold = count.GetKillCount();
        if(hold >= numberOfDrops)
        {
            if (PlayerPrefs.GetInt("highScore", 0) < pt.GetPoints())
            {
                PlayerPrefs.SetInt("highScore", pt.GetPoints());
            }
            DeathController.numberOfdeaths++;
            SceneManager.LoadScene("StartScene");
        }
    }
}
