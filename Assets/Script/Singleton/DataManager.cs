using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager> ,IDataManager
{
    private int _money;
    
    public override void AwakeFunction()
    {
        
    }


    public int GetMoney()
    {
        return _money;
    }

    public void SetMoney(int SetValue)
    {
        _money = SetValue;
    }
    
    
}
