using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    // Start is called before the first frame update
        
        
        public Pickup pick;
        public GameObject selectedObject;
        [SerializeField] private float speed;
    void Start()
        {
            //Fetch the Rigidbody from the GameObject with this script attached


            //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        }

        void FixedUpdate()
        {
            try
            {
                selectedObject = pick.getGameObject();
                int h = selectedObject.GetComponent<RecordID>().getID();

                if (Input.GetKey(KeyCode.R) && selectedObject.GetComponent<RecordID>().getID() == h)
            {
                    Debug.Log("R pressed");
                    selectedObject.GetComponent<Rigidbody2D>().MoveRotation(selectedObject.GetComponent<Rigidbody2D>().rotation + speed * Time.fixedDeltaTime);
                }
            }
            catch
            {

            }
            
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
