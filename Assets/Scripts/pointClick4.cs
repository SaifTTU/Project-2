
using UnityEngine;
using UnityEngine.AI;

public class pointClick4 : MonoBehaviour
{
    public int player = 0;
    public int playerNumber = 4;
    public Camera cam;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {



        if(Input.GetMouseButtonDown(0))
            {// 0 for left click
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

            player = player % 4;
            player = player + 1;
            print("The player is:" + player);
            if (Physics.Raycast(ray, out hit))
            {
                if (player == 4) //mod 4 removing the possibility of above 4 being clicked
                    agent.SetDestination(hit.point);//Move the Agenet
                    
                }
            }
    }
}