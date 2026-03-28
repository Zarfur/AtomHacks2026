using UnityEngine;

public class Damaging : MonoBehaviour
{

    public float cd = 0f;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHp player = other.GetComponent<PlayerHp>();
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
