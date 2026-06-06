using UnityEngine;

public class RushedShowcase : MonoBehaviour
{
    private Vector3 homePillar;
    public GameObject spawnHub;
    public Rigidbody rb;
    public int teleTotal;

    private void Awake()
    {
        homePillar = transform.position;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = spawnHub.transform.position;
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameState >= teleTotal - 1)
        {
            gameObject.SetActive(true);
            rb.isKinematic = false;
        }

        if (GameManager.Instance.gameState == teleTotal)
        {
            transform.position = homePillar;
        }
    }
}
