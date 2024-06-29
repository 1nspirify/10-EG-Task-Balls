using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public enum ItemType 
{
    Empty,
    Ball,
    Barrel,
    Stone,
    Box,
    Dynamite,
    Star,
}
public class Item : MonoBehaviour
{
    public ItemType ItemType;
}
