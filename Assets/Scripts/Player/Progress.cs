using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class Progress : MonoBehaviour
    {
        private int _level = 1;
        private int _currentProgress;
        private int CurrentProgress
        {
            get => _currentProgress;
            set
            {
                if (value >= xpCap)
                {
                    value = 0;
                    LevelUp();
                }
                _currentProgress = value;
                ProgressSlider.value = value;
            } 
        }

        [SerializeField] private float capModifier;
        [SerializeField] private int xpGain, xpCap;
        private Slider ProgressSlider => GetComponent<Slider>();
        [SerializeField] private Text levelText;
        [SerializeField] private GameObject levelTextGo;

        private void Start()
        {
            ProgressSlider.maxValue = xpCap;
        }

        public void AddProgress()
        {
            CurrentProgress += xpGain;
        }

        private void LevelUp()
        {
            _level++;

            print(_level);
            levelTextGo.SetActive(true);
            levelText.text = "Level " + _level;

            ModifyXpCap();
        }

        private void ModifyXpCap()
        {
            var result = xpCap * capModifier;
            xpCap = (int)result;
            ProgressSlider.maxValue = result;
        } 
    }
}
