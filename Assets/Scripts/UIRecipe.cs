using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRecipe : MonoBehaviour
{
    [SerializeField] private Text txtTitle;
    [SerializeField] private Text txtInfo;
    [SerializeField] private Image imgRamen;

    public void SetInfo(string ramenName, string info, Sprite sprite)
    {
        txtTitle.text = ramenName;
        txtInfo.text = info;
        imgRamen.sprite = sprite;
    }
}
