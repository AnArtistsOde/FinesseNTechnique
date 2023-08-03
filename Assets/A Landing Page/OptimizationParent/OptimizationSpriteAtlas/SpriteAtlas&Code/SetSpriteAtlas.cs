using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI; 

[RequireComponent( typeof(Image))]
public class SetSpriteAtlas : MonoBehaviour
{
    [SerializeField] private SpriteAtlas atlas;
        [SerializeField] private string spriteName;
    // Start is called before the first frame update
private void Start()
    {
        GetComponent<Image>().sprite = atlas.GetSprite(spriteName); 
    }
}
