using UnityEngine;
using UnityEngine.Events;

public class RushedShowcase : MonoBehaviour
{
    private Vector3 homePillar;
    public GameObject spawnHub;
    public Rigidbody rb;
    public int teleTotal;
    public UnityEvent onActivate;
    private bool doInvoke;

    private void Awake()
    {
        homePillar = transform.position;
        doInvoke = true;
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

            if (doInvoke) { onActivate.Invoke(); doInvoke = false; }
        }

        if (GameManager.Instance.gameState >= teleTotal)
        {
            rb.isKinematic = true;
            transform.position = transform.position * (1 - Time.deltaTime) + ((homePillar + transform.position) / 2) * Time.deltaTime;
        }
    }
}
