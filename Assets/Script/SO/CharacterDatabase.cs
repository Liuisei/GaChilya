using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SO Item Database", menuName = "Database/Item Database")]
public class CharacterDatabase : ScriptableObject
{
    public List<GachaCharacter> items = new List<GachaCharacter>();
}
