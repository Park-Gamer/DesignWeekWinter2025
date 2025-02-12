using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    //Update health boost value as needed
    public int healthboost = 10;

    void OnTriggerEnter (Collider other)
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

    void Pickup(Collider player)
    {
        player.GetComponent<Player1Controller>().health += healthboost;
        player.GetComponent<Player2Controller>().health += healthboost;
        player.GetComponent<Player3Controller>().health += healthboost;
        player.GetComponent<Player4Controller>().health += healthboost;
        Destroy(gameObject);
    }
}
