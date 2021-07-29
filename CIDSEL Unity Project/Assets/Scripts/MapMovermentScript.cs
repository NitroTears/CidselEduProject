using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovermentScript : MonoBehaviour
{

    public float speed = 0.1f;

    public GameObject topRightLimitGameObject;
    public GameObject bottomLeftLimitGameObject;
    
    private Vector3 topRightLimit;
    private Vector3 bottomLeftLimit;

    private Vector2 input;

    public Animator animator;

    private bool facingRight = true;
    private bool Moving = false;

    void Start () {
        topRightLimit = topRightLimitGameObject.transform.position;
        bottomLeftLimit = bottomLeftLimitGameObject.transform.position;

    }
  
    // Update is called once per frame
    void FixedUpdate()
    {
        

        input = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        

        if((transform.position.x <= bottomLeftLimit.x && input.x == -1) || (transform.position.x >= topRightLimit.x && input.x == 1 ))
        {
            input.x = 0;
        }

        if((transform.position.y <= bottomLeftLimit.y && input.y == -1) || (transform.position.y >= topRightLimit.y && input.y == 1 ))
        {
            input.y = 0;
        }

        if((input.y == 0) || (input.x == 0))
        {
            Moving = false;
        }

        if(input.x == 1 )
        {
           facingRight = true;

        }
        

        if(input.x == -1 )
        {
            facingRight = false;
        } 
        if((input.y == -1) || (input.x == -1 )||(input.y == 1) || (input.x == 1 ))
        {
            Moving = true;

        }

        if ((facingRight == true) && (Moving == true))
        {
            animator.Play("JoeyKangHoppingRight");
        }

        if ((facingRight == false) && (Moving == true))
        {
            animator.Play("JoeyKangHoppingLeft");
        }

        if ((facingRight == true) && (Moving == false))
        {
            animator.Play("JoeyKangIdleRight");
        }
        else if((facingRight == false) && (Moving == false))
        {
            animator.Play("JoeyKangIdleLeft");
        }



       transform.position += new Vector3 (speed * input.x, speed * input.y, 0);
    }
}
