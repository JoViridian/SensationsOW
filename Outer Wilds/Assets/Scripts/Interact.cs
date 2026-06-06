using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public float distAllow;
    private float distInternal;
    public UnityEvent onClick;
    public UnityEvent onHover;
    public UnityEvent onMouseExit;
    public GameObject playerRef;

    private void Update()
    {
        distInternal = (transform.position - playerRef.transform.position).magnitude;
    }

    private void OnMouseOver()
    {
        if (distInternal < distAllow)
        {
            onHover.Invoke();
            //Debug.Log("Detecting");

            if (Input.GetKey(KeyCode.Mouse0))
            {
                onClick.Invoke();
            }
        }
        else
        {
            onMouseExit.Invoke();
        }
    }

    private void OnMouseExit()
    {
        onMouseExit.Invoke();
        Debug.Log("Mouse Exited");
    }

    public void TurnOn(GameObject GO)
    {
        GO.SetActive(true);
    }

    public void TurnOff(GameObject GO)
    {
        GO.SetActive(false);
    }
}
