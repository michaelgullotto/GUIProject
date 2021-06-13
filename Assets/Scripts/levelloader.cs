using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour
{
    public Slider loadingslide;
    public Text progresstxt;
    public static int Index ;

    // tells to call load scence method and what index currently in
    private void Start()
    {
        AsyncLoad(Index);
    }




    // laods next scence and keeps track of scene index
    public void AsyncLoad(int sceneIndex)
    {
        Index++;
        sceneIndex = Index;
        StartCoroutine(loadayschronsly(sceneIndex));

    
    }
    // displays progress to loading next scene
    IEnumerator loadayschronsly (int sceneIndex)
    {
        
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

            while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0 / 9);

            loadingslide.value = progress;
            progresstxt.text = progress * 100f + "%";

            yield return null;
        }
    }


}
