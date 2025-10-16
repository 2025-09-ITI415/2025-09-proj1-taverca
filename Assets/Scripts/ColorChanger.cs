using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ColorChanger : MonoBehaviour
{
    private Renderer objectRenderer;
    public Text ComputerText;
    public GameObject Door;
    public Text CountText;
    public PlayerController playerController;
    public int compcount = 0;

    void Start()
    {
        SetComputerText();
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("Renderer component not found on this GameObject!");
            enabled = false;
        }
    }

    void OnMouseDown()
    {
        // Changes the material's color when clicked
        playerController.compcount += 1;
        compcount += 1;
        SetComputerText();
        if (objectRenderer != null)
        {
            objectRenderer.material.color = Color.black;;
        }
    }
    void SetComputerText()
    {
        ComputerText.text = "Computers: " + playerController.compcount.ToString() + "/6";

    }
}