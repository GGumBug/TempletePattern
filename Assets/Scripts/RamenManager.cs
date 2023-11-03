using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class RamenManager : MonoBehaviour
{
    public static RamenManager instance;

    [SerializeField] private UIRecipe _uiRecipe;

    private void Awake()
    {
        instance = this;
    }
    
    private void Start() 
    {
        var ramen = new AnSeong();
        Tuple<string, StringBuilder, int> result = ramen.HowToMakeRamen();
        Sprite ramenImg = Resources.Load<Sprite>(result.Item3.ToString());
        _uiRecipe.SetInfo(result.Item1, result.Item2.ToString(), ramenImg);
    }
}
