using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public SOKarakter soKarakterInGame;
    public SpriteRenderer karakterImage;
    public float speed;
    public int currentHealth;
    public int health;

    void Start()
    {
        karakterImage.sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
        soKarakterInGame = GameManager.instance.soKarakterManager;
        speed = soKarakterInGame.speed;
        health = soKarakterInGame.health;
        currentHealth = health;
        InGameManager.instance.healthText.text = "Health : " + currentHealth.ToString();
        karakterImage.sprite = soKarakterInGame.karakterSprite;
    }
}
