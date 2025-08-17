using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f; 
    [SerializeField] private float amplitude = 2f; 
    private Vector3 startPosition; 
    private float length;
    [SerializeField] private Camera mainCamera; 

    void Start()
    {
        startPosition = transform.position;
        length = GetComponent<SpriteRenderer>().bounds.size.x; 
    }

    void Update()
    {
        float offset = Time.time * speed;
        float newX = startPosition.x + Mathf.Sin(offset) * amplitude;
        transform.position = new Vector3(newX, startPosition.y, startPosition.z);

        if (mainCamera != null)
        {
            float temp = mainCamera.transform.position.x * (1 - speed);
            if (temp > startPosition.x + length / 2)
            {
                startPosition.x += length;
            }
            else if (temp < startPosition.x - length / 2)
            {
                startPosition.x -= length;
            }
        }

        float newY = startPosition.y + Mathf.Cos(offset) * amplitude * 0.5f;
        transform.position = new Vector3(newX, newY, startPosition.z);
    }
}