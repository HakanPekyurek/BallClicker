using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    private float referansRatio;
    private float screenRatio;
    
    // Start is called before the first frame update
    void Start()
    {
        referansRatio = 9f / 16f;
        screenRatio = (float)Screen.width / (float)Screen.height;
        mainCamera.orthographicSize += Mathf.Abs(referansRatio - screenRatio);
    }
}
