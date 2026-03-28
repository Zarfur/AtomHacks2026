using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] public Rigidbody2D target;
    [SerializeField] public Rigidbody2D rigidBody;
    [SerializeField] private float speed;
    private float xVelo;
    private float yVelo;


    void Awake()
    {
        rigidBody.gravityScale = 0f;
    }

    void Update(){

        //from unity documentation
        Vector2 heading = target.position - rigidBody.position;
        var distance  = heading.magnitude;
        var direction = heading / distance;

        xVelo = direction.x;
        yVelo = direction.y;
        rigidBody.position += new Vector2(xVelo * speed, yVelo * speed);
    }
}
