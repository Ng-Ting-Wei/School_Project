using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenuScript : MonoBehaviour
{
    public GameObject instructionmenu;
    public GameObject levelMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (instructionmenu != null)
            instructionmenu.SetActive(false);
        if (levelMenu != null)
            levelMenu.SetActive(false);

        levelMenu.SetActive(false);
        instructionmenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void onLevelmenu()
    {
        levelMenu.SetActive(true);
    }

    public void offLevelmenu()
    {
        levelMenu.SetActive(false);
    }

    public void onInstruction()
    {
        instructionmenu.SetActive(true);
    }

    public void offInstruction()
    {
        instructionmenu.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
