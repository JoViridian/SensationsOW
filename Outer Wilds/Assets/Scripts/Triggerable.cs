using UnityEngine;
using UnityEngine.Events;

public class Triggerable : MonoBehaviour
{
    public GameObject questBox;
    public UnityEvent doQuiz;

    public void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.gameState++;

        if (GameManager.Instance.triggerState)
        {
            if (GameManager.Instance.gameState <= 2)
            {
                GameManager.Instance.InteractSelect(GameManager.Instance.gameState);
            }
            else
            {
                questBox.SetActive(true);
                doQuiz.Invoke();
            }

            GameManager.Instance.triggerState = false;
            gameObject.SetActive(false);
        }
    }
}
