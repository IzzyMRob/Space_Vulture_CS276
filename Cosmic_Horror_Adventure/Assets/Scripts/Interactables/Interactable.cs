using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    GameObject ParentObj;
    GameObject PopUp;

    void Start()
    {
        // grab pop-up object
        DoorObj = gameObject;
        PopUp = DoorObj.transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // turn on interaction pop-up
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(true);
            collider.PlayerController.CurrentInteractable = DoorObj;
        }

    }

    void OnTriggerExit2D(Collider2D collider)
    {
        // turn off interaction pop-up
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(false);
        }

    }

    public abstract void Use();

}
