using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sfxSource;

    [Header("--------Clips--------")]
    public AudioClip scoreSound;
    public AudioClip wrongClickSound;
    private GameManager gameManager;

    private void Start() {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void PlaySFX(AudioClip clip)
    {
        if (!gameManager.isGameOver)
        {
            sfxSource.PlayOneShot(clip);
        }
    }
}
