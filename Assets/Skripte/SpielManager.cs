using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielManager : MonoBehaviour
    
{
    public GameObject pausePanel;
    bool pauseScreen = false;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(pauseScreen);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseScreen = !pauseScreen;
            pausePanel.SetActive(pauseScreen);
        }
    }

    public void ExitGame() 
    {
        Application.Quit();    
    }
}
