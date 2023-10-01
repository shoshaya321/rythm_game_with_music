using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControler : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode keyCodeToPress;
    // Start is called before the first frame update
    void Start()
    {
        DefaultScale = transform.localScale;

        theSR = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCodeToPress))
        {
         theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyCodeToPress))
        {
            theSR.sprite = defaultImage;
        }
        
    }
}
