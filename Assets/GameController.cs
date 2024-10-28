using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public int kills;
    public int totalEnemies;
    public GameObject Win;
    public GameObject Lose;
    [SerializeField] private TextMeshProUGUI killsText;
    [SerializeField] private TextMeshProUGUI winText;

    void Start()
    {

        totalEnemies = GameObject.FindGameObjectsWithTag("Enemigo").Length;
        UpdateUI();
    }

    public void AddKill()
    {
        kills++;
        UpdateUI();
        if (kills == totalEnemies)
        {
            win();
        }
    }

    private void UpdateUI()
    {
        killsText.text = kills.ToString() + " / 3" ;
    }

    private void win()
    {
        Win.SetActive(true);
    }

    public void lose()
    {
        Lose.SetActive(true);
    }
}
