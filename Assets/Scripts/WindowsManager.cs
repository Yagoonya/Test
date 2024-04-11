using UnityEngine;

namespace Scripts
{
    public class WindowsManager : MonoBehaviour
    {
        public void OnPlayGame()
        {
            CreateWindow("UI/PlayWindow");
        }
        public void OnShowSettings()
        {
            CreateWindow("UI/SettingsWindow");
        }

        private void CreateWindow(string resourcePath)
        {
            var window = Resources.Load<GameObject>(resourcePath);
            Instantiate(window, transform);
        }
    }
}