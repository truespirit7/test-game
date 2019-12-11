using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1
        Vector3 currentPosition = transform.position;
        // 2
        if (Input.GetButton("Fire1"))
        {
            // 3
            Vector3 moveToward = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // 4 
            moveDirection = moveToward - currentPosition;
            moveDirection.z = 0;
            moveDirection.Normalize();
        }
    }
}
