using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    [SerializeField] public Rigidbody2D target;
    [SerializeField] private float movementSpeed;

    void LateUpdate()
    {// follow player with lerp
        Vector3 desiredPosition = target.position;
        Vector3 tweenPosition = Vector3.Lerp(transform.position, desiredPosition, movementSpeed * Time.deltaTime);
        transform.position = new Vector3(tweenPosition.x, tweenPosition.y, transform.position.z);
    }
}
