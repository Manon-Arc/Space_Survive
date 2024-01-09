using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public TMP_Text scoreText;

    private void Start()
    {
        StartCoroutine(IncreaseScoreCoroutine());
    }

    private IEnumerator IncreaseScoreCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            score++;
            scoreText.text = "Score : " + score.ToString();
        }
    }
    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}