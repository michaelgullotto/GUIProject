using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangetrigger : MonoBehaviour
{
   
    public void Playgame()
    {
        // load scene from customization menu
        SceneManager.LoadScene("loading");
    }
}
