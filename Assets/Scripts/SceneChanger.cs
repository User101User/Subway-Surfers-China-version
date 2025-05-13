using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace
using UnityEngine.UI; // Import the UI namespace

public class SceneChanger : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}