using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        if(transform.position.x <= -7.25 && xDirection < 0 || transform.position.x >= 7.25 && xDirection > 0)
        {
            return;
        }
        else
        {
            transform.position = new Vector3(transform.position.x + moveStep, transform.position.y, 0);
        }

        
    }
}
