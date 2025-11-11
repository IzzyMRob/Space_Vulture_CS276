using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public float MoveSpeed = 5f;
    public GameObject Player;

    // Private Variables


    // Methods
    void FixedUpdate() {
        MovePlayer();
    }

    void MovePlayer() {
        // Calculate variables
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");
        Vector2 MoveDir = new Vector2(MoveX, MoveY);

        // move the player 
        transform.Translate(MoveDir * MoveSpeed);
    }
}
