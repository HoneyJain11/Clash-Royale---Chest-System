using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChestConfiguration", menuName = "ScriptableObjects/NewChestConfiguration")]

public class ChestConfiguration : ScriptableObject
{
    [Serializable]
    public class ChestConfig
    {
        public ChestType ChestType;
        public ChestScriptableObject ChestSO;
    }

    public ChestConfig[] ChestConfigurationArray;
}
