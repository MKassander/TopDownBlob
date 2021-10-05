using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public static Progress instance;

    private int _level = 1;
    private int _currentProgress;
    public int xpAmount;
    private Slider ProgressSlider => GetComponent<Slider>();

    private void Start()
    {
        instance = this;
    }

    public void AddProgress()
    {
        _currentProgress += xpAmount;
        ProgressSlider.value = _currentProgress;
        
        if (!(_currentProgress >= ProgressSlider.maxValue)) return;
        _level++;
        Debug.Log("Level " + _level);
        ProgressSlider.value = ProgressSlider.minValue;
        _currentProgress = (int)ProgressSlider.minValue;
        //TODO: Add 
    }
}
