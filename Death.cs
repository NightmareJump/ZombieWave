using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Canvas deathCanvas;
     
    void Start()
    {
        deathCanvas.enabled = false;
    }

    // Update is called once per frame

        public void death()
    {
        deathCanvas.enabled = true;
       // Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void Update()
    {
        
    }
}
