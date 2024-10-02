using System;
using UnityEngine;

public class KeyTracker : MonoBehaviour
{
    public static KeyCode GetLastKeyPressed()
    {
        foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(keyCode))
            {
                return keyCode;
            }
        }
        return KeyCode.None;
    }
}
