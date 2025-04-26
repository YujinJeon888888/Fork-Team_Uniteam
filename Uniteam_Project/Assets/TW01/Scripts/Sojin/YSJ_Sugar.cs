using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSJ_Sugar : MonoBehaviour
{
    public GameObject UIController;
    /// <summary>
    /// Called when [mouse down].설탕을 클릭했는지 확인
    /// </summary>
    void OnMouseDown()
    {
        print($"{gameObject.name}clicked!");
    }
}
