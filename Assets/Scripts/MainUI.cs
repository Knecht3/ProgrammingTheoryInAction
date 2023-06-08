using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// INHERITANCE
public class MainUI : UI
{
    public TextMeshProUGUI currentUserText;
    public TextMeshProUGUI lastUserText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MainManager.Instance != null)
        {
            DisplayCurrentUser();
            DisplayLastUser();
        }
    }

    void DisplayCurrentUser()
    {
        currentUserText.text = MainManager.Instance.userNameTemp + "'s Music Room";
    }

    void DisplayLastUser()
    {
        lastUserText.text = "Last user: " + MainManager.Instance.userName;
    }
}
