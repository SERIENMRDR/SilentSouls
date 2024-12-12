using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    bool isActive = false;
    // Start is called before the first frame update


    public GameObject pauseMenu;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if(isActive)
        {
            pauseMenu.SetActive(false);
            isActive = false;
        }
        else if(!isActive)
        {
            pauseMenu.SetActive(true);
            isActive = true;
        }
       
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        isActive = false;
    }
}
