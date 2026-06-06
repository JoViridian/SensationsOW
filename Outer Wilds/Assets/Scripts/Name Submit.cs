using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class NameSubmit : MonoBehaviour
{
    [HideInInspector] public string name1;
    [HideInInspector] public string name2;
    public TextMeshProUGUI textBox1;
    public TextMeshProUGUI textBox2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name1 = null;
        name2 = null;
    }

    // Update is called once per frame
    void Update()
    {
        textBox1.text = name1;
        textBox2.text = name2;
        //Debug.Log(name1 + name2);
    }

    public void GiveName(string s)
    {
        if (s != null)
        {
            if (GameManager.Instance.gameState == 1)
            {
                name1 = s;
                //Debug.Log(name1);

            }
            else if (GameManager.Instance.gameState == 2)
            {
                name2 = s;
                //Debug.Log(name2);

            }
        }
    }

}
