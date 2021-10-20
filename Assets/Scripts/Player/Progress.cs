using UI;
using UnityEngine;

namespace Player
{
    public class Progress : MonoBehaviour
    {
        [SerializeField] private float capModifier;
        [SerializeField] private int xpGain, xpCap;
        [SerializeField] private ProgressFeedback feedback;

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
                feedback.SetSliderValue(value);
            } 
        }

        private void Start()
        {
            feedback.SetSliderMaxValue(xpCap);
        }

        public void AddProgress()
        {
            CurrentProgress += xpGain;
        }

        private void LevelUp()
        {
            _level++;

            feedback.EnableAndUpdateLevelText(_level);

            ModifyXpCap();
        }

        private void ModifyXpCap()
        {
            var result = xpCap * capModifier;
            xpCap = (int)result;
            feedback.SetSliderMaxValue(xpCap);
        } 
    }
}
