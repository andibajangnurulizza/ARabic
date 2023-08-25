using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAudio : MonoBehaviour
{
    public AudioClip audioClip;
    private Button button;
    private AudioSource audioSource;

    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();

        // Menambahkan event listener saat tombol ditekan
        button.onClick.AddListener(PlayAudio);
    }

    void PlayAudio()
    {
        // Memainkan audio clip
        audioSource.PlayOneShot(audioClip);
    }
}
