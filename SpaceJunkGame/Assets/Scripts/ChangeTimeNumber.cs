using UnityEngine;
using UnityEngine.UI;

public class ChangeTimeNumber : MonoBehaviour
{
    public Text time;
    public int Time = 180;

    void Update()
    {
        time.text = Time.ToString();
    }
}
