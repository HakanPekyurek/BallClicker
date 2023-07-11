using UnityEngine;

public class PlayerRotater : MonoBehaviour
{
    public float rotateSpeed;
    private float spinDirection;
    private float verticalInput;
    private GameManager gameManager;

    private void Start()
    {
        spinDirection = 1;
        verticalInput = Input.GetAxis("Vertical");
        rotateSpeed = 70f;
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    void RotatePlayer()
    {
        if (!gameManager.isGameOver)
        {
            ChangeSpinDirection();
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime * spinDirection);
        }
    }
    
    private float ChangeSpinDirection()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            spinDirection = -spinDirection;
        }

        return spinDirection;
    }
}
