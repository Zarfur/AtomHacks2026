using UnityEngine;

public class Damaging : MonoBehaviour
{
    [SerializeField] BoxCollider2D collider;
    void OnTriggerEnter(BoxCollider2D other){
        Debug.Log("Hit other");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
