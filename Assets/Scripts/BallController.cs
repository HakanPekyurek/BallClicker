using UnityEngine;

public class BallController : MonoBehaviour
{
    private SpawnManager spawnManager;
    private PlayerController playerController;
    private GameManager gameManager;
    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        playerController = FindObjectOfType<PlayerController>();
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ControlIsTrigger();
    }

    void ControlIsTrigger()
    {
        if (playerController.isTrigger && Input.GetKeyDown(KeyCode.Mouse0))
        {
            spawnManager.InstantiateRandomObject();
            gameManager.AddScore();
            Destroy(gameObject);
            playerController.isTrigger = false;
            audioManager.PlaySFX(audioManager.scoreSound);
        }
        else if (!playerController.isTrigger && Input.GetKeyDown(KeyCode.Mouse0))
        {
            gameManager.UpdateLive();
            audioManager.PlaySFX(audioManager.wrongClickSound);
        }
    }
}
