using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private float speed = 5.0f;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(speed, 0, 0); //.1 to the x (or the left)
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed, 0, 0); //.1 to the x (or the left)
        //red is x
        //blue is z
        //green is y, or up
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}
