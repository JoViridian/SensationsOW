using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI textBox;

    // Update is called once per frame
    void Update()
    {
        textBox.text = "You got " + GameManager.Instance.correctScore + " / " + GameManager.Instance.totalScore + " correct! Press R to go again";
        Cursor.lockState = CursorLockMode.Confined;
    }
}
