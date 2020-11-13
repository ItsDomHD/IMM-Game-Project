using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class MenuManager : MonoBehaviour
    {
        public Button Start;
        public Button Showcase;
        public Button Settings;
        public Button Source;
        public Button About;
        public Button Exit;

        public void MMStart()
        {
        }

        public void MMShowcase()
        {
        }

        public void MMSettings()
        {
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
            SceneManager.LoadScene("Main Menu");
        }
    }
}