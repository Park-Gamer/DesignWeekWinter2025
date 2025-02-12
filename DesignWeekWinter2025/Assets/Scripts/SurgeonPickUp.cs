using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurgeonPickUp : MonoBehaviour
{
    //Update surgeon heal amount if needed after playtest
    public int healer = 20;

    //Confirm tag consistency
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Peasant"))
        {
            Pickup(other);
        }

        else if (other.CompareTag("Peasant2"))
        {
            Pickup(other);
        }

        else if (other.CompareTag("Peasant3"))
        {
            Pickup(other);
        }
        else if (other.CompareTag("Peasant4"))
        {
            Pickup(other);
        }
    }

    //Does the players have a slot to carry inventory or a cooldown option 
    //where the needle "disappears" if the player doesn't collide with another player?
    void Pickup(Collider player)
    {
        Destroy(gameObject);
    }
}
