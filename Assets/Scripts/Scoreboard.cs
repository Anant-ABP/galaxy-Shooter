using System.Runtime;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMP_Text scoretext;

    int Score = 0;
    public void IncreaseScore(int amount)
    {
        Score += amount;
        scoretext.text = Score.ToString(); 
    }
}
