using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTotal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Points[] trigBoxs;
    int total;

    void Start()
    {
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        total = 0;
        for (int x = 0; x < trigBoxs.Length; x++)
        {
            total += trigBoxs[x].GivePoints();
        }
    }

    public int GetPoints()
    {
        return total;
    }
}
