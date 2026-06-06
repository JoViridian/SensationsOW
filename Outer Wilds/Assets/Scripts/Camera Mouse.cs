using UnityEngine;

public class CameraMouse : MonoBehaviour
{
    public float sensitivity = 1;
    public float clampAngleTop;
    public float clampAngleBot;
    public float clampAngleLeft;
    public float clampAngleRight;
    private float rotationX;
    private float rotationY;
    [HideInInspector] public bool camLock;

    private void Awake()
    {
        camLock = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (camLock)
        //{
            //Cursor.lockState = CursorLockMode.Confined;
        //}


        DoCamMove();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void DoCamMove()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        rotationY += mouseX * sensitivity * Time.deltaTime;
        rotationX -= mouseY * sensitivity * Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, clampAngleTop, clampAngleBot);
        rotationY = Mathf.Clamp(rotationY, clampAngleLeft, clampAngleRight);

        if (transform.parent != null)
        {
            transform.parent.rotation = Quaternion.Euler(0, transform.rotation.y, 0);
            transform.rotation = Quaternion.Euler(rotationX, 0, 0);
            transform.parent.rotation = Quaternion.Euler(0, rotationY, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        }
    }
}
