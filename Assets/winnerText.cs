using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winnerText : MonoBehaviour
{
    public TMP_Text tmpText;

    public void Start()
    {
        tmpText.text = WinnerData.instance.winnerName + " WIN !";
    }
}
