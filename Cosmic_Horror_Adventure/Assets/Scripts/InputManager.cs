using UnityEngine;

public class InputManager : MonoBehaviour
{

    public PlayerController pc;

    void start()
    {
        pc = GameObject.PlayerController;
    }

    void OnInteract()
    {
        pc.CurrentInteract.Use;
    }
    
}
