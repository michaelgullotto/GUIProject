using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    private void Start()
    {
        levelloader.Index = 1;
    }

    public void Playgame ()
    {
        // load scene from main menu
        SceneManager.LoadScene("loading");
    }
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
