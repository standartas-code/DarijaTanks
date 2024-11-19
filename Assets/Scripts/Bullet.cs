using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explotionPrefab;
    public float speed = 20f;
    public float lifetime = 2f;

    void Start()
    {
        Invoke("SelfDestruct", lifetime);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var health = collision.gameObject.GetComponent<Health>();
        if(health != null)
        {
            health.TakeDamage(10);
        }

        SelfDestruct();
    }

    void SelfDestruct()
    {
        Instantiate(explotionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
