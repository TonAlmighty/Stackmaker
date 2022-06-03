using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Swipe swipeControls;
    public Transform tf;
    public Vector3[,] brickCanMove = new Vector3[20,20];
    public Vector3 targetPos;
    public bool canMove = true;

    public bool down;
    public bool up;
    public bool left;
    public bool right;
    void Start()
    {
        tf = transform;

        for(int i = 0; i < 20; i++)
        {
            for(int j = 0; j < 20; j++)
            {
                brickCanMove[i, j] = new Vector3(i,0,j);
            }
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        //Check directtion
        if (swipeControls.SwipeRight)
        {
            right = true;
            //up = false;
            //left = false;
            //down = false;
           
            targetPos = tf.position;
            for (int i = 0; i <20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    if (brickCanMove[i,j] ==  targetPos)
                    {
                        // Debug.Log(targetPos);
                        targetPos.x = brickCanMove[i,j].x;
                        targetPos.x++;
                    }
                }
                
                        
            }           
        }

        //if (swipeControls.SwipeLeft)
        //{
        //    right = false;
        //    up = false;
        //    left = true;
        //    down = false;
        //    //tf.position = Vector3.MoveTowards(tf.position, new Vector3(3, 0, 0), 1f);
        //    targetPos = tf.position;
        //    for (int i = brickCanMove.Length-1; i >=0; i--)
        //    {
        //        if (brickCanMove[i].x == targetPos.x)
        //        {
        //          //  Debug.Log(targetPos);
        //            targetPos.x = brickCanMove[i].x;
        //            targetPos.x--;
        //       }
        //        else
        //        {
        //            break;
        //        }
        //    }                                                    
        //}

        //if (swipeControls.SwipeUp)
        //{
        //    right = false;
        //    up = true;
        //    left = false;
        //    down = false;
        //    //tf.position = Vector3.MoveTowards(tf.position, new Vector3(3, 0, 0), 1f);
        //    targetPos = tf.position;
        //    for (int i =0 ; i < brickCanMove.Length; i++)
        //    {
        //       if (brickCanMove[i].z == targetPos.z)
        //        {
        //         //   Debug.Log(targetPos);
        //            targetPos.z = brickCanMove[i].z;
        //            targetPos.z++;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }            
        //}

        //if (swipeControls.SwipeDown)
        //{
        //    right = false;
        //    up = false;
        //    left = false;
        //    down = true;
           
        //    canMove = true;
        //    //tf.position = Vector3.MoveTowards(tf.position, new Vector3(3, 0, 0), 1f);
        //    targetPos = tf.position;
        //    for (int i = brickCanMove.Length-1; i >=0 ; i--)
        //    {
        //        if (brickCanMove[i].z == targetPos.z)
        //        {
        //           // Debug.Log(targetPos);
        //            targetPos.z = brickCanMove[i].z;
        //            targetPos.z--;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }          
        //}

        //Movevement
        if (down)
        {
            if (tf.position.z != (targetPos.y+1))
            {
                tf.position = Vector3.MoveTowards(tf.position, new Vector3(tf.position.x, tf.position.y, targetPos.y + 1), 1f);
               
            }
            else
            {
                down = false;
            }
        }
        if (up)
        {
            if (tf.position.z != (targetPos.y - 1))
            {
                tf.position = Vector3.MoveTowards(tf.position, new Vector3(tf.position.x, tf.position.y, targetPos.y - 1), 1f);
                Debug.Log(targetPos);
            }
            else
            {
                up = false;
            }
        }
        if (left)
        {
            if (tf.position.x != (targetPos.x + 1))
            {
                tf.position = Vector3.MoveTowards(tf.position, new Vector3(targetPos.x + 1, tf.position.y, tf.position.z), 1f);
            }
            else
            {
                left = false;
            }
        }
        if (right)
        {
            if (tf.position.x != (targetPos.x - 1))
            {
                tf.position = Vector3.MoveTowards(tf.position, new Vector3(targetPos.x - 1, tf.position.y, tf.position.z), 1f);
            }
            else
            {
                right = false;
            }
        }

    }
}
