using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    // ENCAPSULATION
    public static MainManager Instance { get; private set; }
    private string m_userNameTemp;
    public string userNameTemp
    {
        get { return m_userNameTemp; }
        set
        {
            if (value.Length > 9)
            {
                isNameTooLong = true;
                Debug.LogError("Name entered too long!");
            }
            else
            {
                isNameTooLong = false;
                m_userNameTemp = value;
            }
        }
    }

    public string userName;
    public bool isNameTooLong;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadData();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
    class Data
    {
        public string userName;
    }

    // ABSTRACTION
    public void SaveData()
    {
        Data data = new Data();
        data.userName = userName;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);
            userName = data.userName;
        }
    }
}
