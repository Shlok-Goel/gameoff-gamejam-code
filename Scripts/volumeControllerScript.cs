using UnityEngine.UI;
using UnityEngine;

public class volumeControllerScript : MonoBehaviour
{
   
    [SerializeField] private Slider volumeSlider; // Reference to the UI Slider
    private const string VolumePrefKey = "Volume"; // Key for saving volume settings

    private void Start()
    {
        // Load saved volume or set default
        float savedVolume = PlayerPrefs.GetFloat(VolumePrefKey, 0.5f);
        volumeSlider.value = savedVolume;
        AdjustVolume(savedVolume);

        // Add listener to handle slider value changes
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    private void AdjustVolume(float value)
    {
        AudioListener.volume = value; // Set the global volume
        PlayerPrefs.SetFloat(VolumePrefKey, value); // Save the value
        PlayerPrefs.Save();
    }

    private void OnDestroy()
    {
        volumeSlider.onValueChanged.RemoveListener(AdjustVolume); // Clean up listener
    }

}
