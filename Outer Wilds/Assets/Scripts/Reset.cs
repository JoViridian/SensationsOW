using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Debug.Log("load?");
        }
    }
}
