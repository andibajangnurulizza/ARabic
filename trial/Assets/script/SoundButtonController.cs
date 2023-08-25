using UnityEngine;
using UnityEngine.UI;

public class SoundButtonController : MonoBehaviour
{
    public Button[] soundButtons; // Array of Button objects
    public AudioClip[] audioClips; // Array of AudioClips

    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component on the same GameObject

        // Initialize the sound buttons
        InitializeSoundButtons();
    }

    private void InitializeSoundButtons()
    {
        // Loop through each sound button
        for (int i = 0; i < soundButtons.Length; i++)
        {
            int index = i; // Store the index in a local variable for the button click event

            // Add a click listener to the button
            soundButtons[i].onClick.AddListener(() =>
            {
                PlaySound(index);
            });
        }
    }

    private void PlaySound(int index)
    {
        // Check if the index is valid
        if (index >= 0 && index < audioClips.Length)
        {
            // Play the corresponding audio clip
            audioSource.PlayOneShot(audioClips[index]);
        }
    }
}
