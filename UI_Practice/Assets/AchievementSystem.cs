using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementSystem : MonoBehaviour
{
    public Text achievementSystem;

    public void UnlockAchievement(string title)
    {
        Debug.Log("�������� ����! - " + title);
        achievementSystem.text = "�������� ����! - " + title;
    }
}
