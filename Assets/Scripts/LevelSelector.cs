﻿using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButtons;

   void Start ()
   {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i - 6 > levelReached)
              levelButtons[i].interactable = false;
        }
   }
    public void Select(int levelIndex)
    {
        fader.FadeTo(levelIndex);
    }
}