using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageExample : MonoBehaviour
{
    public Image myImage;
    public Sprite newSprite;

    // Start is called before the first frame update
    void Start()
    {
        myImage.sprite = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
