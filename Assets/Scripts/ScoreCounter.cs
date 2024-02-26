using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    TMPro.TextMeshPro Score;

    public void Awake()
    {
        Score = new TMPro.TextMeshPro();
    }
    public void ButtonUP()
    {
        score += 15;
        Score = new TMPro.TextMeshPro();
    }
}
