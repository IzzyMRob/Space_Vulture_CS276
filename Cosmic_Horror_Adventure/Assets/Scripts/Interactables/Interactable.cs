using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    GameObject PopUp;
    public GameObject PlayerObj;

    void Start()
    {
        // grab pop-up object
        PopUp = gameObject.transform.GetChild(0).gameObject;
        PlayerObj = null;
        GetSpecificValues();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // turn on interaction pop-up, set player's current interactable to this one
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log(gameObject.name + " - Player entered trigger zone");
            PopUp.SetActive(true);
            PlayerObj = collider.gameObject;
            PlayerObj.GetComponent<PlayerController>().SetCurrentInteractable(gameObject);
            Debug.Log("CurrentInteractable set to: " + gameObject.name);
        }

    }

    void OnTriggerExit2D(Collider2D collider)
    {
        // turn off interaction pop-up, set player's current interactable to none
        if (collider.gameObject.tag == "Player")
        {
            PopUp.SetActive(false);
            PlayerObj.GetComponent<PlayerController>().CurrentInteractable = null;
            ProximityTurnOff();
        }

    }

    public abstract void Use();
    public abstract void GetSpecificValues();
    public abstract void ProximityTurnOff();

}
