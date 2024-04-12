using UnityEngine;

public abstract class GachaCharacter : ScriptableObject
{
    public string    characterName; // キャラクターの名前
    public Texture    characterIcon; // キャラクターのアイコン

    public abstract void ActivateAbility(GameObject player);  // アビリティをアクティベートする抽象メソッド
}