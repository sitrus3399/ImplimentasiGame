using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ball", menuName = "ScriptableObjects/New Ball")]
public class SOBall : ScriptableObject
{
    public float speed;
    public int poin;
    public float radius;
    public Sprite ballSprite;
}
