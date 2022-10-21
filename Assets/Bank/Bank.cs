using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalace = 150;

    [SerializeField] int currentBalace;
    public int CurrentBalace { get { return currentBalace; } }

    [SerializeField] TextMeshProUGUI displayBalance;

    void Awake()
    {
        currentBalace = startingBalace;
        UpdateDisplay();
    }

    public void Deposit(int amout)
    {
        currentBalace += Mathf.Abs(amout);
        UpdateDisplay();
    }

    public void Withdraw(int amout)
    {
        currentBalace -= Mathf.Abs(amout);
        UpdateDisplay();

        if (currentBalace < 0)
        {
            //Lose the game
            ReloadScene();
        }
    }

    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalace;
    }

    void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
