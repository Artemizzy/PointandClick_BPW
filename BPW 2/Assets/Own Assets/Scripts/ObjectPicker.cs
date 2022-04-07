using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    public Animator m_Animator;
    public Animator l_Animator;
    public Camera camera;


    void Update()
    {
        if (!Input.GetMouseButton(0)) return;

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            GameObject collidedObject = hit.collider.gameObject;

            switch(collidedObject.tag)
            {
                case "Clock":

                    m_Animator.SetTrigger("DayNightTrigger");
                    l_Animator.SetTrigger("LightTrigger");

                    break;

                case "Calender":
                    m_Animator.SetTrigger("SeasonsTrigger");
                    break;
                
                
            }
        }
    }
}
