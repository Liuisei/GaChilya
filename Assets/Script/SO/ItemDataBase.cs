using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SO Item Database", menuName = "Database/Item Database")]
public class ItemDatabase : ScriptableObject
{
    public List<GachaCharacter> items = new List<GachaCharacter>();
}
