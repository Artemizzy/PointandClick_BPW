using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float rotationAmount = 1.0f;
    private Vector3 originalRotation;

    private void Start()
    {
        originalRotation = transform.eulerAngles;
    }

    void Update()
    {
        float screenCenter = 0.0f;
        screenCenter = Screen.width / 2f;

        Vector3 mousePos = Input.mousePosition;

        if(mousePos.x < screenCenter)
        {
            transform.eulerAngles = originalRotation + new Vector3(0, Mathf.Lerp(-rotationAmount, 0f, mousePos.x/screenCenter));
        } else
        {
            transform.eulerAngles = originalRotation + new Vector3(0, Mathf.Lerp(0f, rotationAmount, (mousePos.x-screenCenter) / screenCenter));
        }
    }
}
