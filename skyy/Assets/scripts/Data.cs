using System;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data Instance;
    public GameData gameData;

    int screenID;

    private void Awake()
    {
        Instance = this;
        gameData = GetComponent<GameData>();
    }
    void Start()
    {
#if !UNITY_EDITOR
        Cursor.visible = false;
#endif
        gameData.Load("data.json", Init);
    }  

    void Init()
    {
    }

}
