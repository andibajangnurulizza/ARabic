using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadUrl()
    {
         Application.OpenURL("https://drive.google.com/drive/folders/1ztLy9Rh5nQnYzsBUEJ-An4A5FMAa0yiV?usp=sharing");
    }
}
