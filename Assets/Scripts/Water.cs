using System;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject Waters;

    void OnTriggerEnter(Collider hit) {
        if (hit.CompareTag("Player"))
            {
            GameObject.Find("Player").SendMessage("React");
        }


    }

}

