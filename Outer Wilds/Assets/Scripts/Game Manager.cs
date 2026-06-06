using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Manager Set-up

    // GM's singleton for easy access throughout the whole project
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        // setup singleton
        if (instance != null)
            Destroy(instance.gameObject);
        instance = this;
    }

    public CameraMouse mouse;
    public Movement wasd;
    public TMP_InputField nameBoxA;
    public TMP_InputField nameBoxB;
    public GameObject trigger;
    public TextMeshProUGUI scoreBox;
    [HideInInspector] public int gameState;
    [HideInInspector] public bool triggerState;
    [HideInInspector] public int answer;
    [HideInInspector] public bool answerState;
    [HideInInspector] public int correctScore;

    private void Start()
    {
        gameState = 0;
        triggerState = true;
        answer = 0;
        answerState = false;
        correctScore = 0;
    }

    void Update()
    { 

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (correctScore >= 10)
        {
            SceneManager.LoadScene(2);
        }

        scoreBox.text = "" + correctScore;
        //Debug.Log(gameState + "/" + triggerState); 
    }

    public void ProgressState()
    {
        gameState++;
    }

    public void ActivateTrigger()
    {
        triggerState = true;
        StartCoroutine(ReactivateDelay(trigger));
    }

    IEnumerator ReactivateDelay(GameObject GO)
    {
        yield return new WaitForSeconds(1f);
        answerState = false;
        GO.SetActive(true);
    }

    public void InputSwap(GameObject GO)
    {
        GO.SetActive(false);
        //mouse.camLock = !mouse.camLock;
        //wasd.moveLock = !wasd.moveLock;
    }

    public void InteractSelect(int a)
    {
        if (a == 1)
        {
            nameBoxA.gameObject.SetActive(true);
            nameBoxA.Select();
        }
        else
        {
            nameBoxB.gameObject.SetActive(true);
            nameBoxB.Select();
        }
    }
}
