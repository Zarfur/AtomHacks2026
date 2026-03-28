using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    //[SerializeField] private Animator myAnimator;

    public float walkSpeed;
    private float horizontal;
    private float vertical;
    [SerializeField] private float movementFactor;
    private bool isLeft = false;

    void Awake()
    {
        rigidBody.freezeRotation = true;
        rigidBody.gravityScale = 0f;
    }


    void FixedUpdate()
    {
        // Player controls
        if(Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed){
            //myAnimator.SetBool("isRunning", true);
            horizontal = -movementFactor;
        }
        else if(Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed){
            //myAnimator.SetBool("isRunning", true);
            horizontal = movementFactor;
        }
        else{ 
            //myAnimator.SetBool("isRunning", false);
            horizontal = 0;
        }

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed){
            //myAnimator.SetBool("isRunning", true);
            vertical = movementFactor;
        }
        if(Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed){
            //myAnimator.SetBool("isRunning", true);
            vertical = -movementFactor;
        }
        else{
            //myAnimator.SetBool("isRunning", false);
            vertical = 0;
        }
        rigidBody.position += new Vector2(horizontal * walkSpeed, vertical * walkSpeed);
        flip();

    }

    private void flip()
    {// flip back forward
        if ( (horizontal > 0 && !isLeft) || (horizontal < 0 && isLeft))
        {
            isLeft = !isLeft;
            float scaled = -1 * transform.localScale.x;
            transform.localScale = new Vector3(scaled, transform.localScale.y, transform.localScale.z);
        }
    }
}