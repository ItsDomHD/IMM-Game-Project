using UnityEngine;
using UnityEngine.Audio;

namespace DefaultNamespace
{
    public class SettingsMenu : MonoBehaviour

    {
        public AudioMixer audioMixer;
        private float currentVolume;

        public void SetVolume(float volume)
        {
            audioMixer.SetFloat("volume", volume);
            currentVolume = volume;
        }

        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }
    }
}