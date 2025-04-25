using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSJ_PickController : MonoBehaviour
{
    int clickCounter = 0;
    public GameObject UI;

    public void Add_Click(GameObject clone)
    {
        clickCounter++;
        print($"clickCount: {clickCounter}");
        Destroy(clone);

        UI.GetComponent<YSJ_UIController>().Display_PickCounts(clickCounter); 
        //다른 스크립트의 함수값을 가져옴
    }
}
