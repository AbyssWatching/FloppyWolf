using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxScript : MonoBehaviour
{

    public Rigidbody2D rg2D;

    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true){


            rg2D.velocity = Vector2.up * jump;
        
        }
    }
}
