using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigManager
{

    private static Dictionary<string, UUIData> gameUIConfig = new Dictionary<string, UUIData>();

    public void Init()
    {
        //初始化
    }

    public static Dictionary<string, UUIData> GetUIConfig()
    {
        return gameUIConfig;
    }
}