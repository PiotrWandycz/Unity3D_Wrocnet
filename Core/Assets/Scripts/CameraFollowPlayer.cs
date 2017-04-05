﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject Player;

    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
    }
}