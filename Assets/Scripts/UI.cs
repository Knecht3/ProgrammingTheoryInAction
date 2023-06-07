using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UI : MonoBehaviour
{
    // Save data then exit the game
    public void Exit()
    {
        if (MainManager.Instance != null)
        {
            MainManager.Instance.userName = MainManager.Instance.userNameTemp;
            MainManager.Instance.SaveData();
        }
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
