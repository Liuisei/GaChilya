using UnityEngine;

public class GachaManager : Singleton<GachaManager>
{
    public CharacterDatabase characterDatabase; // CharacterDatabaseの参照

    public override void AwakeFunction()
    {
    }
    // ガチャを引くメソッド
    public GachaCharacter DrawGacha()
    {
        int index = Random.Range(0, characterDatabase.items.Count); // ランダムなインデックスを取得
        return characterDatabase.items[index];                      // ランダムに選ばれたキャラクターを返す
    }
    
}