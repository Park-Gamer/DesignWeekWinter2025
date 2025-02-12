using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverBullet : MonoBehaviour
{
    //Update slowdown speed value as needed
    public float slowdown = 5f;
    
    //Update tag once werewolf is declared
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Werewolf"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        player.GetComponent<WerewolfController>().dashSpeed -= slowdown;
        Destroy(gameObject);
    }
}
