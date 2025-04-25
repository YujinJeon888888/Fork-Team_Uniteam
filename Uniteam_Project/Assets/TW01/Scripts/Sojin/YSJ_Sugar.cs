using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSJ_Sugar : MonoBehaviour
{
    public GameObject UIController;


    void OnMouseDown()
    {
        print($"{gameObject.name}clicked!");
    }
}
