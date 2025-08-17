using UnityEngine;
using UnityEngine.Audio;

public class dragonSound : MonoBehaviour
{ 
public AudioClip dragonFly; 
private AudioSource audioSource;

void Start()
{
    audioSource = GetComponent<AudioSource>();
}

void Update()
{
    audioSource.PlayOneShot(dragonFly);
}
}

