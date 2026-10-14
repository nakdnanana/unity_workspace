using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{

    public float speed = 100.0f;
    public float force = 50.0f;
    private Rigidbody _rigidbody;

    private void DeleteMePls()
    {
        Destroy(gameObject);
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Invoke("DeleteMePls", 2.0f);
    }

    
    void Update()
    {
        _rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var rb = collision.collider.gameObject.GetComponent<Rigidbody>();
        if (rb)
        {
            var dir = (collision.contacts[0].point - transform.position);
            rb.AddForce(dir * force);
        }
        DeleteMePls();
    }
}
