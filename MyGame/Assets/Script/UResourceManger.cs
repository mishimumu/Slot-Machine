using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class UResourceManger : Singleton<UResourceManger>
{


    public T Load<T>() where T : UnityEngine.Object
    {
        return null;
    }

    public void Destory(GameObject obj, bool isCache = true)
    {
        if (isCache)
        {
            obj.SetActive(false);
        }
        else
        {
            MonoBehaviour.Destroy(obj);
        }
    }


}


