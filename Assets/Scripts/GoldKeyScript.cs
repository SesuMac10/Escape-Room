using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class GoldKeyScript : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int finalScore;
    [SerializeField] private UnityEvent winAction;
    
    public void UpdateScore()
    {
        score++;
        if(score == finalScore)
        {
            winAction.Invoke();
        }
    }
}
