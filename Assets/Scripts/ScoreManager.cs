using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI currentScoreUI;
    public int currentScore;
    public TextMeshProUGUI bestScoreUI;
    public int bestScore;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreUI.text = "Best Score(Sehee Lee): " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
