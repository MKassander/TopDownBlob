using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacterColor : MonoBehaviour
{
    private SkinnedMeshRenderer SkinnedMeshRenderer => GetComponent<SkinnedMeshRenderer>();
    void Start()
    {
        SkinnedMeshRenderer.material.color = CharacterColor.PlayerColor;
    }
}
