using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameData
{
    public int indexCurrentScene;
    //here we need to store items as well

    public GameData(int indexCurrentScene)
    {
        this.indexCurrentScene = indexCurrentScene;
    }

}
