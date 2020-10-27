using UnityEngine; //very often used 

public class FirstScript : MonoBehaviour
{

    int score = 10;

    float speed = 2.5F;

    char character = '1';

    string name = "Saif";

    // Start is called before the first frame update
    void Start()
    {
        
        print("Welcome Player: "+character+": "+name);
        
    }

    // Update is called once per frame
    void Update() //we dont have to create our own game loop
        //its already made
    {
        //print("Car Move");//gets called again and again and again
        //when clicked
    }
}
