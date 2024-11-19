using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var health = other.gameObject.GetComponent<Health>();
        if(health != null)
        {
            health.TakeDamage(-10);
            Destroy(gameObject);
        }
        
    }

}
