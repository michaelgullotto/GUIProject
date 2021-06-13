using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    private void Start()
    {
        // keeps track of scence  index for level loader
        levelloader.Index = 1;
    }

    public void Playgame ()
    {
        // load scene from main menu
        SceneManager.LoadScene("loading");
    }
    // dosent do anything cause i dont need to load from menu
     public void loadGame()
    {
        Debug.Log("loaded Game");
    }
    public void Quitgame ()
    {
        // quits game from main menu
         Debug.Log("quit");
         Application.Quit();
        
    }
}
