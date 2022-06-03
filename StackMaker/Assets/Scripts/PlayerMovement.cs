using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Swipe swipeControls;
    public Transform tf;
    public List<Vector3> brickCanMove;
    public Vector3 targetPos;
    //[SerializeField]
    //private bool canMove = false;

    [SerializeField]
    private bool right = false;
    [SerializeField]
    private bool left = false;
    [SerializeField]
    private bool up = false;
    [SerializeField]
    private bool down = false;

  
    void Start()
    {
        tf = transform;
        targetPos = tf.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (swipeControls.SwipeRight)
        {
            right = true;
        }
        if (swipeControls.SwipeLeft)
        {
            left = true;
        }
        if (swipeControls.SwipeUp)
        {
            up = true;
        }
        if (swipeControls.SwipeDown)
        {
            down = true;
        }


        if (right)
        {
            if (brickCanMove.Contains(targetPos))
            {
                targetPos += Vector3.right;

                Debug.Log( "RIGHT: "+targetPos);
            }
            else
            {
                if(tf.position.x != (targetPos.x - 1))
                {
                    tf.position = Vector3.MoveTowards(tf.position, new Vector3(targetPos.x - 1, tf.position.y, targetPos.z), 0.2f);
                    
                    Debug.Log("RIGHT 1: ");
                }
                else
                {
                    right = false;
                    targetPos = tf.position;
                    Debug.Log("RIGHT 2: ");
                }
               
            }
            
        }


        if (left)
        {
            if (brickCanMove.Contains(targetPos))
            {
                targetPos += Vector3.left;

                Debug.Log("LEFT : " + targetPos);
            }
            else
            {
                if (tf.position.x != (targetPos.x + 1))
                {
                    tf.position = Vector3.MoveTowards(tf.position, new Vector3(targetPos.x + 1, tf.position.y, targetPos.z), 0.2f);
                }
                else
                {
                    left = false;
                    targetPos = tf.position;
                }
            }

        }
        if (up)
        {
            if (brickCanMove.Contains(targetPos))
            {
                targetPos += Vector3.forward;

                Debug.Log("UP : " + targetPos);
            }
            else
            {
                if (tf.position.z != (targetPos.z - 1))
                {
                    tf.position = Vector3.MoveTowards(tf.position, new Vector3(targetPos.x, tf.position.y, targetPos.z -1), 0.2f);
                }
                else
                {
                    up = false;
                    targetPos = tf.position;
                }
            }

        }

        if (down)
        {
            if (brickCanMove.Contains(targetPos))
            {
                targetPos += Vector3.back;

                Debug.Log("Down : " + targetPos);
            }
            else
            {
                if (tf.position.z != (targetPos.z + 1))
                {
                    tf.position = Vector3.MoveTowards(tf.position, new Vector3(targetPos.x, tf.position.y, targetPos.z + 1), 0.2f);
                }
                else
                {
                    down = false;
                    targetPos = tf.position;
                }
            }

        }


    }
}



    

