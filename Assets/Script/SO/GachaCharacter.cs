using UnityEngine;

public abstract class GachaCharacter : ScriptableObject
{
    public string    characterName; // キャラクターの名前
    public Sprite    characterIcon; // キャラクターのアイコン
    public AudioClip soundEffect;   // サウンド効果

    public abstract void ActivateAbility(GameObject player);  // アビリティをアクティベートする抽象メソッド
}