using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Vector3 dir = Vector3.right;
    public float speed;
    public float max_left;
    public float max_right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > max_left)
        {
            dir = Vector3.left;
            Debug.Log("Moving Left");
        }
        if (transform.position.x < max_right)
        {
            dir = Vector3.right;
            Debug.Log("Moving Right");
        }
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
