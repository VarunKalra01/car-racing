using UnityEngine;
using UnityEngine.UI;

public class MuteUnmute : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public Button muteButton;
    private bool isMuted = false;

    void Start()
    {
        if (muteButton != null)
        {
            muteButton.onClick.AddListener(ToggleMute);
            UpdateButtonText();
        }
    }

    void ToggleMute()
    {
        isMuted = !isMuted;
        backgroundMusic.mute = isMuted;
        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        if (isMuted)
        {
            muteButton.GetComponentInChildren<Text>().text = "Unmute";
        }
        else
        {
            muteButton.GetComponentInChildren<Text>().text = "Mute";
        }
    }
}
