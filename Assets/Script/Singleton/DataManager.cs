using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager>, IDataManager
{
    [SerializeField]
    private int _money;

    public Action OnMoneyChanged;

    
    public override void AwakeFunction()
    {
        
    }
    public int Money
    {
        get { return _money; }
        set
        {
            _money = value;
            OnMoneyChanged?.Invoke();
        }
    }
}