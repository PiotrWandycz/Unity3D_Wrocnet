using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    void Start()
    {

    }

    void FixedUpdate()
    {
        HandleShooting();
    }

    void HandleShooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Resources.Load("Prefabs/Bullet"), transform.position + new Vector3(0.4f, -0.1f, 0.0f), transform.rotation);
        }
    }
}
