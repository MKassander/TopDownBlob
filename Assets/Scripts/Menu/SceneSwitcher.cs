using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class SceneSwitcher : MonoBehaviour
    {
        public void IncrementSceneIndex()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
