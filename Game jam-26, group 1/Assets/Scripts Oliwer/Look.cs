using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float _mouseSen = 100f;
    public Transform _player;
    float _xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Låser vår mus till skärmen, och så den inte syns. 
    }
    void Update()
    {
        //Hämtar vår axis från input manager under project settings
        float mouseX = Input.GetAxis("Mouse X") * _mouseSen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSen * Time.deltaTime;
        _xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f); //Vi använder rotate för att vi ska kunna stoppa rotationen från att gå förlångt / snurra ett helt varv
        _player.Rotate(Vector3.up * mouseX);
    }
}
