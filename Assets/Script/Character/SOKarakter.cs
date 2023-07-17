using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Karakter", menuName = "ScriptableObjects/New Karakter")]
public class SOKarakter : ScriptableObject
{
    public float speed;
    public int health;
    public Sprite karakterSprite;
}
