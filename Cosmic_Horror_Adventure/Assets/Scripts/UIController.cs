using System.Collections.Generic;
using Assets.WUG.Scripts;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;


public class UIController : MonoBehaviour
{
    public GameObject Canvas;
    bool Active;

    void Start()
    {
        Canvas.SetActive(true);
        Canvas.SetActive(false);
    }

    public void ToggleInventory()
    {
        // if already on, turn it off
        if (Active) {
            Active = false;
            Canvas.SetActive(false);
            Time.timeScale = 1;
        }
        //if already off, turn it on
        else {
            Active = true;
            Canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

}