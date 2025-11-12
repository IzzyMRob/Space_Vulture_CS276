using UnityEngine;

public class Door : Interactable
{

    public GameObject Connection;

    public override void Use()
    {
        Debug.Log("Used Door");
    }
}
