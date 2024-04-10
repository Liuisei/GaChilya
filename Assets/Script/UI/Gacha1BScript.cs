using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gacha1BScript : MyButton
{
    protected override void OnButtonUp()
    {
        SceneManager.LoadScene(1);
        Debug.Log("MoveToGacha");
    }
}
