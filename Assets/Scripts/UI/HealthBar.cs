using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HealthBar : MonoBehaviour
    {
        private Slider Slider => GetComponent<Slider>();

        public void UpdateVal(int val)
        {
            Slider.value = val;
        }
    }
}
