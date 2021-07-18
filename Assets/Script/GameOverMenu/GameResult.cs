using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameResult : MonoBehaviour
{
    TextMeshProUGUI resultText;
    void Start()
    {
        resultText = GetComponent<TextMeshProUGUI>();
        if (GameManager.instance.farmerIsDirty)
        {
            resultText.text = "Dirty Farmer!";
        }
        else if (GameManager.instance.bombExploded)
        {
            resultText.text = "Bomb Exploded!";
        }
        else
        {
            resultText.text = "Game Over!";
        }
    }
}
