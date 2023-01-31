using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{

    public float moveSpeed = 5; 

    public float destroyGO = -11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < destroyGO)
        {
            Debug.Log("Pipe is deleted");
            Destroy(gameObject);
        }
    }
}
