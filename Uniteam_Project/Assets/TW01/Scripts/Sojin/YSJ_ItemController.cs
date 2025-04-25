using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSJ_ItemController : MonoBehaviour
{
    public GameObject PickController;

    void OnMouseDown()
    {
        print($"{gameObject.name} clicked!");
        PickController.GetComponent<YSJ_PickController>().Add_Click(gameObject);
        //pickController에 보고
       
    }
}
