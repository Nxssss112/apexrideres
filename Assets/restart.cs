using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartToPreviousScene : MonoBehaviour
{
    public int previousSceneIndex; 

    public void RestartToPrevious()
    {
        Debug.Log("RestartToPrevious called! Scene Index = " + previousSceneIndex); 
        SceneManager.LoadScene(previousSceneIndex); 
    }
}