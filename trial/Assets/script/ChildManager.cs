using UnityEngine;
using UnityEngine.SceneManagement;

public class ChildManager : MonoBehaviour
{
    public GameObject[] childObjects;
    private int currentChildIndex = 0;

    public void ActivateNextChild()
    {
        if (currentChildIndex < childObjects.Length)
        {
            childObjects[currentChildIndex].SetActive(false);
            currentChildIndex++;
            if (currentChildIndex < childObjects.Length)
            {
                childObjects[currentChildIndex].SetActive(true);
            }
            else
            {
                SceneManager.LoadScene("Menu Utama");
            }
        }
    }

    public void DeactivateCurrentChild()
    {
        if (currentChildIndex >= 0)
        {
            childObjects[currentChildIndex].SetActive(false);
            currentChildIndex--;
            if (currentChildIndex >= 6)
            {
                childObjects[currentChildIndex].SetActive(true);

            }
        }
    }
}
