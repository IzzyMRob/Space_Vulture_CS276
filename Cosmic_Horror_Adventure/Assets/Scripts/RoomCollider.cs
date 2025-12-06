using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using System.Collections;

public class RoomCollider : MonoBehaviour
    {
        public string RoomName;
        public GameObject TopBlock;
        private GameObject Text;

    void Start()
    {
        Text = TopBlock.transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // turn on interaction pop-up, set player's current interactable to this one
        if (collider.gameObject.tag == "Player")
        {
            Text.GetComponent<TMP_Text>().text = "Entered " + RoomName;
            StartCoroutine(ShowRoomText());
        }
    }

    IEnumerator ShowRoomText()
    {
        TopBlock.SetActive(true);
        yield return new WaitForSeconds(3); // Wait for 3 seconds
        TopBlock.SetActive(false);
    }


    }