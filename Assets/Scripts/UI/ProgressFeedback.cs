using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ProgressFeedback : MonoBehaviour
    {
        private Slider ProgressSlider => GetComponent<Slider>();
        [SerializeField] private Text levelText;
        [SerializeField] private GameObject levelTextGo;

        public void SetSliderValue(int val)
        {
            ProgressSlider.value = val;
        }
    
        public void SetSliderMaxValue(int val)
        {
            ProgressSlider.maxValue = val;
        }

        public void EnableAndUpdateLevelText(int level)
        {
            levelTextGo.SetActive(true);
            levelText.text = "Level " + level;
        }
    }
}
