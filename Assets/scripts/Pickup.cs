using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject selectedObject;
    public AudioSource pickUp;
    Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject && !targetObject.gameObject.CompareTag("Base"))
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
                pickUp.Play();
            }
        }

        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
        }

        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }

    public GameObject getGameObject()
    {
        return selectedObject;
    }
}