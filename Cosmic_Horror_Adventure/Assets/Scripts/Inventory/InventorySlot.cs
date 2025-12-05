using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

namespace Assets.WUG.Scripts
{
    public class InventorySlot : VisualElement
    {
        public Image Icon;
        public string ItemGuid = "";
        public Image ItemImage;

        public InventorySlot()
        {
            //Create a new Image element and add it to the root
            Icon = new Image();
            Add(Icon);

            //Add USS style properties to the elements
            Icon.AddToClassList("slotIcon");
            AddToClassList("slotContainer");
        }

        public void HoldItem(string name, Sprite sprite)
        {
            // set name
            ItemGuid = name;
            // new image, add to class, update image
            Debug.Log("HoldItem Called");
            Icon = new Image();
            Icon.sprite = sprite;
            Debug.Log(Icon.sprite);
            Icon.SetEnabled(true);
            Add(Icon);
        }
    }
}