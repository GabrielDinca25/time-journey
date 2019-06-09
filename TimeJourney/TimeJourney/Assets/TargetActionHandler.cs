﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetActionHandler : MonoBehaviour
{
    public GameObject objectToMove;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Shot"))
        {
            Debug.Log(other.name);
            objectToMove.SetActive(true);
            Destroy(gameObject);
            other.gameObject.SetActive(false);
        }
    }
}
