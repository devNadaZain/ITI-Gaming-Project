using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreElement : MonoBehaviour
{
    ScoreManager ScoreManager => ScoreManager.Instance;
    public AudioSource coinAudio;
    void Start()
    {
        coinAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            coinAudio.Play();

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            ScoreManager.AddScore(1);
            Destroy(gameObject, coinAudio.clip.length);
        }
    }

}
