using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

// INHERITANCE
public class MenuUI : UI
{
    public TextMeshProUGUI userNameInputText;

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
        if (!MainManager.Instance.isNameTooLong)
        {
            SceneManager.LoadScene(1);
        }
    }

    void GetUserName()
    {
        MainManager.Instance.userNameTemp = userNameInputText.text;
    }
}
