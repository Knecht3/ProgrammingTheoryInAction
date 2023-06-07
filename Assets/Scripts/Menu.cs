using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI inputUserName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetUserName();
    }

    // Load main scene
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Exit the game
    public void Exit()
    {
        MainManager.Instance.userName = MainManager.Instance.userNameTemp;
        MainManager.Instance.SaveData();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    void GetUserName()
    {
        MainManager.Instance.userNameTemp = inputUserName.text;
    }
}
