using UnityEngine;

public class Damaging : MonoBehaviour
{
    PlayerHp player;
    public float cd = 0f;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Logic").GetComponent<PlayerHp>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(cd > 2f){
                cd = 0f;
                player.takeDamage();
            }
        }
    }


    void Update()
    {
        cd += Time.deltaTime;
    }

}
