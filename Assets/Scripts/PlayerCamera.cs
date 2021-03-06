﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    private Vector3 offset;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;//offsets camera from players postion
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;//offsets camera from players postion
    }
}
