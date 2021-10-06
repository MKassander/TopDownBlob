using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Fade
{
    public class FadeText : MonoBehaviour
    {
        [SerializeField] private int lerpTime, activeTime;
    
        private Text Text => GetComponent<Text>();
        private bool _fadeIn;

        private void OnEnable()
        {
            _fadeIn = true;
            StartCoroutine(FadeOut());
        }

        private void Update()
        {
            Text.CrossFadeAlpha(_fadeIn ? 255 : 1, lerpTime, false);
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
