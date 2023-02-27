using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float currentYPos;
    // Start is called before the first frame update
    void Start()
    {
        currentYPos = GetComponent<Transform>().position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentYPos >= 0 && currentYPos < 110)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Debug.Log("up");
                transform.position += new Vector3(0f, 0.01f, 0f);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                //Debug.Log("down");
                transform.position -= new Vector3(0f, 0.01f, 0f);
            }
        }
        else if(currentYPos <= 0)
        {
            transform.position = new Vector3(0f, 0f, -10f);
        }
        else if(currentYPos > 110)
        {
            transform.position = new Vector3(0f, 110f, -10f);
        }

        currentYPos = GetComponent<Transform>().position.y;
    }
}
