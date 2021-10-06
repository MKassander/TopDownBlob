using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Fade
{
    public class FadeImage : MonoBehaviour
    {
        [SerializeField] private int lerpTime, activeTime;
        private Image Image => GetComponent<Image>();
        private bool _fadeIn;

        private void OnEnable()
        {
            _fadeIn = true;
            StartCoroutine(FadeOut());
        }

        private void Update()
        {
            Image.CrossFadeAlpha(_fadeIn ? 100 : 1, lerpTime, false);
        }
        
        private IEnumerator FadeOut()
        {
            yield return new WaitForSeconds(lerpTime + activeTime);
            _fadeIn = false;

            StartCoroutine(Disable());
        }

        private IEnumerator Disable()
        {
            yield return new WaitForSeconds(3);
            gameObject.SetActive(false);
        }
    }
}
