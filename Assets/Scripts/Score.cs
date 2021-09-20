using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    public Transform player;

    void Update()
    {
        if (player.position.y >= 1)
        {
            score.text = player.position.z.ToString("0");
        }
    }

}
