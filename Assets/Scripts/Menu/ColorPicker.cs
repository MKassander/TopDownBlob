using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public SkinnedMeshRenderer SkinnedMeshRenderer;
    public Color[] Colors;
    private int Index;

    public void ToggleNextColor()
    {
        if (Index == Colors.Length-1) Index = 0;
        else Index++;
        SetColor();
    }
    
    public void ToggleLastColor()
    {
        if (Index == 0) Index = Colors.Length-1;
        else Index--;
        SetColor();
    }

    void SetColor()
    {
        SkinnedMeshRenderer.material.color = Colors[Index];
        CharacterColor.PlayerColor = Colors[Index];
    }
}
