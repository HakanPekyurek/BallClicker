using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
            isTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }
}
