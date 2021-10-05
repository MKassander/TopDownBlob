using Menu;
using UnityEngine;

public class SetCharacterColor : MonoBehaviour
{
    private SkinnedMeshRenderer SkinnedMeshRenderer => GetComponent<SkinnedMeshRenderer>();

    private void Start()
    {
        SkinnedMeshRenderer.material.color = CharacterColor.playerColor;
    }
}
