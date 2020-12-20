using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class MenuManager : MonoBehaviour
    {
        public void MMStart()
        {
            SceneManager.LoadScene("Scenes/Start/Shooting Range");
        }

        public void MMShowcase()
        {
            SceneManager.LoadScene("Scenes/Showcase/Showcase");
        }

        public void MMSettings()
        {
            SceneManager.LoadScene("Scenes/Main Menu/Main Menu - Settings");
        }

        public void MMSource()
        {
            Application.OpenURL("https://github.com/ItsDomHD/IMM-Game-Project");
        }

        public void MMAbout()
        {
            SceneManager.LoadScene("Scenes/Main Menu/Main Menu - About");
        }

        public void MMQuit()
        {
            Application.Quit();
        }

        public void MMBack()
        {
            SceneManager.LoadScene("Scenes/Main Menu/Main Menu");
        }
        public void ShowcaseGun1()
        {
            SceneManager.LoadScene("Scenes/Showcase/Showcase - AK47");
        }
        public void ShowcaseGun2()
        {
            SceneManager.LoadScene("Scenes/Showcase/Showcase - Pistol");
        }
    }
}