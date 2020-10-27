using UnityEngine;

public class CursorLockExample : MonoBehaviour
{
    public bool freeLook = true;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    

    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;

            if (freeLook == true)
            {
                freeLook = false;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
            }

            else if (freeLook == false)
            {
                freeLook = true;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            }

            
        }

        if (Input.GetKey(KeyCode.Space))
        {
            freeLook = true;
            //Cursor.lockState = CursorLockMode.Locked;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        
        }
    }
    void OnGUI()
    {
        
        if (GUI.Button(new Rect(0, 0, 100, 50), "Lock Cursor"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

       //Press this button to confine the Cursor within the screen
        if (GUI.Button(new Rect(125, 0, 100, 50), "Confine Cursor"))
        {
            Cursor.lockState = CursorLockMode.Confined;
        } 
        


        //Press this button to confine the Cursor within the screen
        if (GUI.Button(new Rect(250, 0, 100, 50), "Free Look"))
        {
                freeLook = true;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (GUI.Button(new Rect(375, 0, 100, 50), "Free Move"))
        {
                Cursor.lockState = CursorLockMode.Locked;
                freeLook = false;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}