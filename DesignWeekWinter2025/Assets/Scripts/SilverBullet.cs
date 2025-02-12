using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverBullet : MonoBehaviour
{
    //Update slowdown speed value as needed
    public float slowdown = 0.05f;
    public float slowdown_dash = 5f;

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
        player.GetComponent<WerewolfController>().moveSpeed -= slowdown;
        player.GetComponent<WerewolfController>().dashSpeed -= slowdown_dash;
        Destroy(gameObject);
    }
}
