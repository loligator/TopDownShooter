﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item  : ScriptableObject {
    public int itemID = -1;
    new public string name = "New Item";
    public Sprite icon = null;
    public int maxQuantity = 1;
}
