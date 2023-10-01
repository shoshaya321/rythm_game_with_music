using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePreesed;
    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePreesed)
            {
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();

            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePreesed = true;
           
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canBePreesed = false; 
        GameManager.instance.NoteMissed();
    }
}
