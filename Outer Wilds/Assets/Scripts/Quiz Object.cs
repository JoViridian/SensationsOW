using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizObject : MonoBehaviour
{
    public bool complex = false;
    public int id;

    void Update()
    {
        if (!complex && GameManager.Instance.answerState)
        {
            Destroy(gameObject);
        }
    }

    public void DoScore()
    {
        if(!GameManager.Instance.answerState)
        {
            if (GameManager.Instance.answer == id)
            {
                GameManager.Instance.correctScore++;
            }
            else if (!GameManager.Instance.triggerState)
            {
                SceneManager.LoadScene(1);
            }

            GameManager.Instance.answerState = true;
        }
    }
}
