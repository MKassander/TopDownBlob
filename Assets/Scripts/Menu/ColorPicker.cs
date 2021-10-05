using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] private Color[] colors;
    private int _index;

    public void ToggleNextColor()
    {
        if (_index == colors.Length-1) _index = 0;
        else _index++;
        SetColor();
    }
    
    public void ToggleLastColor()
    {
        if (_index == 0) _index = colors.Length-1;
        else _index--;
        SetColor();
    }

    void SetColor()
    {
        skinnedMeshRenderer.material.color = colors[_index];
        CharacterColor.PlayerColor = colors[_index];
    }
}
