using System.Collections.Generic;
using System.Reflection.Emit;
using Assets.WUG.Scripts;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Dictionary<string, Sprite> HeldItems;
    public GameObject UserInterface;
    public GameObject IncomeLabel;
    private int Income = 0;

    void Start()
    {
        HeldItems = new Dictionary<string, Sprite>();
    }

    public void Add(string name, Sprite sprite, int value)
    {
        HeldItems.Add(name, sprite);
        Income += value;
        IncomeLabel.GetComponent<TMP_Text>().text = Income + " Credits";
    }

    public bool IsHolding(string name) 
    {
        if (HeldItems.ContainsKey(name)) {
            return true;
        }
        else {
            return false;
        }
    }
}
