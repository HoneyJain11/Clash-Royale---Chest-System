using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestModel
{
    public float DurationUnlock { get; set; }
    public int MinCoin { get; set; }
    public int MaxCoin { get; set; }
    public string ChestName { get; set; }
    public Sprite ChestSprite { get; set; }
    public int MinGem { get; set; }
    public int MaxGem { get; set; }


    public ChestModel(ChestScriptableObject chestScriptableObject)
    {
        ChestName = chestScriptableObject.spriteName;
        ChestSprite = chestScriptableObject.sprite;
        DurationUnlock = chestScriptableObject.durationUnlock;
        MinCoin = chestScriptableObject.minCoin;
        MaxCoin = chestScriptableObject.maxCoin;
        MinGem = chestScriptableObject.minGem;
        MaxGem = chestScriptableObject.maxGem;
    }

   

    
}
