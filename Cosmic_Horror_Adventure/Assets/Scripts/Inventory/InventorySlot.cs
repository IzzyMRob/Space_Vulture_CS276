﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UIElements.Image;

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
            ItemGuid = name;
            Icon.sprite = sprite;
        }

        public void ClearItem()
        {
            ItemGuid = "";
            Icon.sprite = null;
        }
    }
}