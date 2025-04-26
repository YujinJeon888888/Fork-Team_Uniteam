using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class YSJ_PickController.
/// </summary>
public class YSJ_PickController : MonoBehaviour
{
    /// <summary>
    /// The click counter
    /// </summary>
    int clickCounter = 0;
    /// <summary>
    /// The UI
    /// </summary>
    public GameObject UI;

    /// <summary>
    /// Adds the click.
    /// </summary>
    /// <param name="clone">The clone.</param>
    public void Add_Click(GameObject clone)
    {
        clickCounter++;
        print($"clickCount: {clickCounter}");
        

        //UI에 업데이트된 클릭 수 표시
        UI.GetComponent<YSJ_UIController>().Display_PickCounts(clickCounter); 
        PlayerPrefs.SetInt("Score", clickCounter);
        PlayerPrefs.Save();
        Destroy(clone);
    }

}
