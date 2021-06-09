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


    private void Start()
    {
        AsyncLoad(Index);
    }





    public void AsyncLoad(int sceneIndex)
    {
        Index++;
        sceneIndex = Index;
        StartCoroutine(loadayschronsly(sceneIndex));

    
    }

    IEnumerator loadayschronsly (int sceneIndex)
    {
        //sceneIndex = Index;
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
