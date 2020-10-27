
using UnityEngine;
using UnityEngine.AI;

public class pointClick2 : MonoBehaviour
{
    public int player = 0;
    public int playerNumber = 2;
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
                if (player == 2)
                    agent.SetDestination(hit.point);//Move the Agenet
                    
                }
            }
    }
}