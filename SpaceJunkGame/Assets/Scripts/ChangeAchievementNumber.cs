using UnityEngine;
using UnityEngine.UI;

public class ChangeAchievementNumber : MonoBehaviour
{
    public Text achievements;
    public int Achievements = 5;

    void Update()
    {
        achievements.text = Achievements.ToString();
    }
}
