using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        pauseMenu.SetActive(true);
    }

    public void ResumeGame(GameObject pauseMenu)
    {
        pauseMenu.SetActive(false);
    }
}
