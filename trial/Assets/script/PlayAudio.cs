using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayButtonSound()
    {
        if (audioClip != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
