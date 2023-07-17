using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBase : MonoBehaviour
{
    public SOBall[] soBall;
    int randomBall;
    public float speed;
    public int poin;
    public float radius;
    public CircleCollider2D col2D;
    public SpriteRenderer spriteRenderer;
    private Vector3 scaleChange;

    public void Start()
    {
        spriteRenderer.sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
        randomBall = Random.Range(0, soBall.Length);
        col2D = GetComponent<CircleCollider2D>();
        speed = soBall[randomBall].speed;
        poin = soBall[randomBall].poin;
        radius = soBall[randomBall].radius;
        scaleChange = new Vector3(radius, radius, radius);
        transform.localScale = scaleChange;
        col2D.radius = radius * 0.05f;
        spriteRenderer.sprite = soBall[randomBall].ballSprite;
    }

    public void Update()
    {
        transform.position += new Vector3(0, -speed * 0.5f * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InGameManager.instance.GotScore(poin);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Base"))
        {
            InGameManager.instance.GotDamage();
            Destroy(gameObject);
        }
    }

}
