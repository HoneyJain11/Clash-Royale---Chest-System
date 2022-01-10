using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChestScriptableObject", menuName = "ScriptableObjects/NewChestScriptableObject")]
public class ChestScriptableObject : ScriptableObject
{
    public string spriteName;
    public Sprite sprite;
    public float durationUnlock;
    public int minCoin;
    public int maxCoin;
    public int minGem;
    public int maxGem;
}
