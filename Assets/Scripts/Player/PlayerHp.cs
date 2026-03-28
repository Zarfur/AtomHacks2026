using UnityEngine;
using UnityEngine.UI;


public class PlayerHp : MonoBehaviour
{
    public int Health = 100;
    public void takeDamage()
    {
        Health -=1;
        Debug.LogWarning("Took damage");
    }
}
