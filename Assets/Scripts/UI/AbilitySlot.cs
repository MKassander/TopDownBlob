using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class AbilitySlot : MonoBehaviour
    {
        private Slider Slider => GetComponentInChildren<Slider>();
        private Image Image => GetComponent<Image>();
        private float _timer;

        public void TriggerCoolDown(float time)
        {
            Slider.maxValue = time;
            _timer = time;
        }

        private void Update()
        {
            if (!(_timer > 0)) return;
            _timer -= Time.deltaTime;
            Slider.value = _timer;
        }
    }
}
