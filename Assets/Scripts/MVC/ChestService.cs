using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestService :GenericSingleton<ChestService>
{
    public ChestView chestView;
    public ChestController chestController;
    public ChestConfiguration chestConfiguration;

    public ChestController CreateChest(ChestScriptableObject chestScriptableObject)
    {
        ChestModel model = new ChestModel(chestScriptableObject);
        ChestController chest = new ChestController(model);
        return chest;
    }


}
