using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public float radius = 2f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        InstantiateRandomObject();
    }

    public void InstantiateRandomObject()
    {
        if (gameManager.isGameOver == false)
        {
            Instantiate(ballPrefab, CalculateRandomBallPosition(), ballPrefab.transform.rotation);
        }        
    }

    private Vector3 CalculateRandomBallPosition()
    {
        Vector3 position = Vector3.zero;
        float randomAngle = Random.Range(0f, 360f);
        position.x = Mathf.Cos(randomAngle) * radius;
        position.y = Mathf.Sin(randomAngle) * radius;

        return position;
    }    
}
