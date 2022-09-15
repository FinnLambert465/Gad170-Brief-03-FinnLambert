using FinnLambert;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinnCounter : MonoBehaviour
{
    [SerializeField] private int playerOneWinCounter = 0;
    [SerializeField] private TextMeshProUGUI playerOneWinCounterUI;
    [SerializeField] private int playerTwoWinCounter = 0;
    [SerializeField] private TextMeshProUGUI playerTwoWinCounterUI;

    public void OnEnable()
    {
        FinishLine.OnPlayerOneWins += PlayerOneWinCount;
        FinishLine.OnPlayerTwoWins += PlayerTwoWinCount;
    }
    public void OnDisable()
    {
        FinishLine.OnPlayerOneWins -= PlayerOneWinCount;    
        FinishLine.OnPlayerTwoWins -= PlayerTwoWinCount;    
    }



    private void PlayerOneWinCount()
    {
        playerOneWinCounter++;
        playerOneWinCounterUI.text = playerOneWinCounter.ToString();
    }
    private void PlayerTwoWinCount()
    {
        playerTwoWinCounter++;
        playerTwoWinCounterUI.text = playerTwoWinCounter.ToString();
    }
}
