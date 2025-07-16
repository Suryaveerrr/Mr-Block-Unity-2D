using UnityEngine;

public class Player : MonoBehaviour
{
    private float HorizontalInput;
    private float VerticalInput;
    public float speed = 5.0f;
    private Rigidbody2D rb;

    public LevelManager levelManager;
    private SoundManager soundManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        soundManager = FindObjectOfType<SoundManager>();

        if (soundManager == null)
        {
            Debug.LogError("SoundManager not found in the scene.");
        }
    }

    void Update()
    {
        GetInput();
        MovePlayer();
    }

    private void GetInput()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        Vector2 newVelocity = new Vector2(HorizontalInput, VerticalInput).normalized * speed;
        rb.linearVelocity = newVelocity; 
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            PlayerDied();
        }
    }

    private void PlayerDied()
    {
        if (levelManager != null)
        {
            levelManager.OnPlayerDeath();
        }
        else
        {
            Debug.LogWarning("LevelManager not assigned to Player.");
        }

        Destroy(gameObject);
        soundManager.PlayGameOverAudio();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            LevelComplete();
        }
    }

    private void LevelComplete()
    {
        if (levelManager != null)
        {
            levelManager.OnLevelComplete();
        }
        else
        {
            Debug.LogWarning("LevelManager not assigned to Player.");
        }

        gameObject.SetActive(false);
        soundManager.PlayLevelCompleteAudio();

    }
}
