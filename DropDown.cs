using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    [HideInInspector]
    public int arrayIdx = 0;
    [HideInInspector]
    public string[] MyArray = new string[] { "Linsay", "Betty", "Wilma", "Eden" };

    [HideInInspector]
    public int listIdx = 0;
    [HideInInspector]
    public List<string> MyList = new List<string>(new string[] { "Omar", "Henry", "Leslie", "Chris" });

}