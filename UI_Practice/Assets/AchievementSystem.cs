using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementSystem : MonoBehaviour
{
    public Text achievementSystem;

    public void UnlockAchievement(string title)
    {
        Debug.Log("도전과제 해제! - " + title);
        achievementSystem.text = "도전과제 해제! - " + title;
    }
}
