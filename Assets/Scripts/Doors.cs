using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Doors : MonoBehaviour {
    public PlayerController playerController;
    public ColorChanger colorChanger;
    public GameObject Door;
    public int compcount;
    public int count;

    void Update()
    {
        if (playerController.compcount >= 6 && playerController.count >= 4)

        {
            Door.SetActive(false);
        }
    }
}
