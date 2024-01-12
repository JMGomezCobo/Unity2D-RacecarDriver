using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeliveryDriver
{
    public class CollisionController : MonoBehaviour
    {
        [SerializeField] private bool hasPackage;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Pickup") && !hasPackage)
            {
                hasPackage = true;
                Destroy(other.gameObject, 0.5f);
            }
            
            if (other.CompareTag("Drop") && hasPackage)
            {
                hasPackage = false;
            }
        }
    }
}
