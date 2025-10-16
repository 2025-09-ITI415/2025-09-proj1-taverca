using UnityEngine;
using UnityEngine.UI;

public class TextShow : MonoBehaviour
{
    public GameObject Popup;

    void Start()
    {
        if (Popup != null)
        {
            Popup.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Popup != null)
            {
                Popup.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Popup != null)
            {
                Popup.SetActive(false);
            }
        }
    }
}