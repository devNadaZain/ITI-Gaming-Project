using UnityEngine;

public class DangerGround : MonoBehaviour
{
    private bool playerOn = false;

    void Update()
    {
        if (playerOn)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score", 0) - 10);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerOn = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerOn = false;
        }
    }
}