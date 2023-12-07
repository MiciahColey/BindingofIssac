using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
   
    public IssacMovement player;

    public PowerupType type;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other.gameObject.GetComponent<IssacMovement>());
        }




    }

   private void Pickup(IssacMovement Player)
    {
        Debug.Log("Brimestone picked up");

        

        switch (type)
        {
       
            case PowerupType.Brimestone:
                Player.hasbrim = true;
                Player.haswiz = false;
                break;
            case PowerupType.DoubleWiz:
                Player.haswiz = true;
                Player.hasbrim = false;
                break;
            default:
                break;
        }


        Destroy(gameObject);
    }




}

