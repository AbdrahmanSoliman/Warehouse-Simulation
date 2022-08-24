using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void CloseTheApplication() // created this function to be able to add the ExitButton and choose it among functions option https://stackoverflow.com/questions/39669655/how-do-i-quit-in-standalone-or-in-editor-mode
    {
        MainManager.Instance.SaveColor();

        if (EditorApplication.isPlaying) // Check if we are playing the game on Play Mode in in-Editor Mode
        {
            EditorApplication.isPlaying = false;
        }
        else // If not then we are playing the release version of the game
        {
            Application.Quit();
        }
    }
}
