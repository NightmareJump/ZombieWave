using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Zoom : MonoBehaviour
{
    RigidbodyFirstPersonController fpsController;
    [SerializeField] float sensitivity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(1))
        {
            fpsController.mouseLook.XSensitivity = sensitivity;
            fpsController.mouseLook.YSensitivity = sensitivity;
        }*/
       
        if (Input.GetKeyDown(KeyCode.Q))
        {
            fpsController.mouseLook.XSensitivity = sensitivity +1.0f;
            fpsController.mouseLook.YSensitivity = sensitivity + 1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            fpsController.mouseLook.XSensitivity = sensitivity - 1.0f;
            fpsController.mouseLook.YSensitivity = sensitivity -1.0f;
        }
    }
}
