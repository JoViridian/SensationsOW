using UnityEngine;
using UnityEngine.Events;

public class Triggerable : MonoBehaviour
{
    public GameObject questBox;
    public GameObject scoreBox;
    public UnityEvent doQuiz;

    public void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.gameState++;
        //Debug.Log("Triggered" + GameManager.Instance.triggerState);

        if (GameManager.Instance.triggerState)
        {
            if (GameManager.Instance.gameState <= 4)
            {
                GameManager.Instance.InteractSelect(GameManager.Instance.gameState);
            }
            else
            {
                questBox.SetActive(true);
                scoreBox.SetActive(true);
                doQuiz.Invoke();
            }
        }

        GameManager.Instance.answerState = false;
        GameManager.Instance.triggerState = false;
        gameObject.SetActive(false);
    }
}
