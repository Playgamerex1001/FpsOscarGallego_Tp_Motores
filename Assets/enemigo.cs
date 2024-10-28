using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enemigo : MonoBehaviour
{
    public Collision ataque;
    public int health;
    public TextMeshProUGUI enemyHealthUI;
    GameController gameController;

    private void Start()
    {
        UpdateUI();
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void UpdateUI()
    {
        enemyHealthUI.text = health.ToString();
    }

    public void OnCollisionEnter(Collision ataque)
    {
        if (ataque.gameObject.CompareTag("Player"))
        {
            gameController.lose();
        }
    }
    public void ReceiveDamageFromBala(int damage)
    {
        health -= damage;
        UpdateUI();
        if (health <= 0)
        {
            Destroy(this.gameObject);
            gameController.AddKill();

        }
    }
}