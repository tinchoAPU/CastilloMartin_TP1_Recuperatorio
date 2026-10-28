using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    [SerializeField] private float timeToReverse = 3f;

    private int direction = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ReverseDirection", timeToReverse);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
    }

    private void ReverseDirection()
    {
        direction *= -1;

        Invoke("ReverseDirection", timeToReverse);
    }
}
