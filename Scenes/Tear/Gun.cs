using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //public float speedBulet = 1000f;
    public Transform point;
    public GameObject bullet;

    public float delay = 1.0f;
    private float _timer = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (_timer >= 0)
        {
            _timer -= Time.deltaTime;
        }
    }

    public void Activate()
    {
        if (_timer > 0) return;
        GameObject clone = Instantiate(bullet, point.position, point.rotation);
        _timer = delay;
        //Rigidbody rb = clone.GetComponent<Rigidbody>();
        //rb.AddForce(clone.transform.forward * speedBulet);

    }
}
