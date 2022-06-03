using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    // Start is called before the first frame update

    public Swipe swipeControls;
    public Transform tf;
    public float maxDistance = 1f;
    private Vector3 direction;
    private Vector3 desiredPosition;
    public bool canMove = true;
    public bool isMoving = false;
    void Start()
    {
        tf = transform;

    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < 10; i++)
        {
            if(i == 4)
            {
                break;
            }

            Debug.Log(i);
        }

    }

   
    
  
}
