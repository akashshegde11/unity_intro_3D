using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCube : MonoBehaviour
{
    public Vector3 rotateCube;
    public Keyboard keyboard;
    
    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard == null)
        {
            Debug.Log("No keyboard!");
            return;
        }

        if (keyboard.wKey.isPressed)
        {
            transform.Rotate(rotateCube * Time.deltaTime);
            Debug.Log(transform.position);
        }
    }

    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }


}
