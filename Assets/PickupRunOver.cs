using GameDevTV.Inventories;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRunOver : MonoBehaviour
{

    Pickup pickup;

    private void Awake()
    {
        pickup = GetComponent<Pickup>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pickup.PickupItem();
        }
    }
}
