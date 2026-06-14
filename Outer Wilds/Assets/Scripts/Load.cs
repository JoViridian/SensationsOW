using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
 public void LoadScene(int a)
    {
        SceneManager.LoadScene(a);
    }

    public void DoQuit()
    {
        Application.Quit();
    }
}
