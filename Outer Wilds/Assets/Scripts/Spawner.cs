using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject optionA;
    public GameObject optionB;
    public GameObject spawnHub;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoSpawn()
    {
        if (GameManager.Instance.gameState > 2)
        {
            GameObject guess;
            int a = Random.Range(0, 2);
            if(a == 0)
            {
                guess = Instantiate(optionA);

            }
            else
            {
                guess = Instantiate(optionB);
            }

            GameManager.Instance.answer = a;
            guess.transform.position = spawnHub.transform.position;
        }
    }
}
