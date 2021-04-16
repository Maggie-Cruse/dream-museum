using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catalog : MonoBehaviour
{
    [SerializeField] private GameObject catalogUI;
    [SerializeField] private bool isPaused;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        // AudioListener.pause = true;
        catalogUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        // AudioListener.pause = false;
        catalogUI.SetActive(false);
        isPaused = false;
    }
}
