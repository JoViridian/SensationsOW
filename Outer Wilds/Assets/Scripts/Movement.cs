using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController player;
    public float speedMultiplier = 1;
    [HideInInspector] public bool moveLock;

    private void Awake()
    {
        moveLock = false;
    }

    void Update()
    {
        if (!moveLock)
        {
            DoMove();
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1, 0);
        }
    }

    void DoMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.SimpleMove(speedMultiplier * transform.TransformDirection(Vector3.forward));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            player.SimpleMove(speedMultiplier * transform.TransformDirection(Vector3.back));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.SimpleMove(speedMultiplier * transform.TransformDirection(Vector3.left));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            player.SimpleMove(speedMultiplier * transform.TransformDirection(Vector3.right));
        }
    }
}
