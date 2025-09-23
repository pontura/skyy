using UnityEngine;
using YaguarLib.Audio;

public static class Events
{
    public static System.Action<int> ResetApp = delegate { };
    public static System.Action<int> OnTimeOver = delegate { };
    public static System.Action<int, bool> OnWin = delegate { };
}