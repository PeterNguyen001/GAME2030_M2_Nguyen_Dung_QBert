using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform t;
    private Vector3 moveVec = new Vector3(0, 0, 0);
    private Vector3 moveUL = new Vector3(-0.491f, 0.846f, 0);
    private Vector3 moveUR = new Vector3(0.491f, 0.846f, 0);
    private Vector3 moveDL = new Vector3(-0.491f, -0.846f, 0);
    private Vector3 moveDR = new Vector3(0.491f, -0.846f, 0);
    private Vector3 oldPos;
    private Vector3 newPos;
    private bool isMoving = false;
    public float moveTime = 0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveTime -= Time.deltaTime;
        Move();
        //Debug.Log("PastPos:" + oldPos + "\nNewPos:" + newPos + "\nCurrentPos:" + transform.position +"\nDistance:" + Vector3.Distance(newPos, transform.position));
     
    }
    void Move()
    {
        transform.position += moveVec*2 * Time.deltaTime;
        
        if ( Input.GetKeyDown("[7]") )
        {
            Debug.Log("pressed");
            if (!isMoving)
            {
                moveTime = 0.5f;
                isMoving = true;
                moveVec = moveUL;
                oldPos = transform.position;
                newPos = oldPos + moveUL;
  
            }
          
        }
        if (Input.GetKeyDown("[9]"))
        {

            Debug.Log("pressed");
            if (!isMoving)
            {
                moveTime = 0.5f;
                isMoving = true;
                moveVec = moveUR;
                oldPos = transform.position;
                newPos = oldPos + moveUR;
  
            }

        }
        if ( Input.GetKeyDown("[1]"))
        {

            Debug.Log("pressed");
            if (!isMoving)
            {
                moveTime = 0.5f;
                isMoving = true;
                moveVec = moveDL;
                oldPos = transform.position;
                newPos = oldPos + moveDL;
             
            }
            
        }
        if (Input.GetKeyDown("[3]"))
        {
            
            Debug.Log("pressed");
            if (!isMoving)
            {
                moveTime = 0.5f;
                isMoving = true;
                moveVec = moveDR;
                oldPos = transform.position;
                newPos = oldPos + moveDR;
            }
        }
        //Debug.Log("PastPos:" + oldPos + "\nNewPos:" + newPos + "\nCurrentPos:" + transform.position + "\nDistance:" + Vector3.Distance(newPos, transform.position));
        if (moveTime <= 0)
        {
            moveVec = Vector3.zero;
            isMoving = false;
        }
        
    }

}
