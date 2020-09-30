using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TouchInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public HeliController heli;

    public void OnPointerDown(PointerEventData eventData)
    {
        heli.thrust = true;

        if (heli == null)
        {
            SceneManager.LoadScene("Helicopter");
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        heli.thrust = false;
    }
}
