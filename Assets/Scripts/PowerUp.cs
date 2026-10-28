using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 1.8f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.GetComponent<PlayerMovement>() != null)
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();

            if (player != null)
            {
                player.ApplySpeedBoost(speedMultiplier);
            }

            Destroy(gameObject);
        }
    }
}