
using UnityEngine;
using UnityEngine.AI;

public class gazeMove : MonoBehaviour
{
    public int player = 0;
    
    public Camera cam;
    public NavMeshAgent agent;
    //public bool gaze =true;

    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //print("The player is:" + player);
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);//Move the Agenet

            }
        
    }
    
}