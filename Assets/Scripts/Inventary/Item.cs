using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Potion", menuName = "Items/Potion", order = 1)]

public class Item : ScriptableObject
{

    [SerializeField]
    Sprite icon;

    [SerializeField]
    string objectName = "Potion";
    
    [SerializeField, TextArea(3, 10)]
    string description;




}
