using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class StartButton : MonoBehaviour
    {
        public void StartFunction()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
