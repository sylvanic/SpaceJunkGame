using UnityEngine;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour
{
    public Text score;
    public int Score = 10;

    void Update()
    {
        score.text = Score.ToString();
    }
}
