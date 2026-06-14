using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class QuizObject : MonoBehaviour
{
    public bool complex = false;
    public int id;
    public UnityEvent onCorrect;
    public UnityEvent onFail;

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
                GameManager.Instance.totalScore++;
                onCorrect.Invoke();
            }
            else if (!GameManager.Instance.triggerState)
            {
                GameManager.Instance.totalScore++;
                onFail.Invoke();
            }

            GameManager.Instance.answerState = true;
        }
    }
}
