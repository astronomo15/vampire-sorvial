using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : WeaponBase
{
    BoxCollider2D collisor;
    SpriteRenderer spriteR;
    public int destroyChance;
    void Start()
    {
        collisor = GetComponent<BoxCollider2D>();
        spriteR = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Enemy":
                Enemy enemy = collision.GetComponent<Enemy>();
                enemy.TakeDamage(enemy.life);
                break;
            case "XP":
                if (Random.Range(0, 100) <= destroyChance)
                {
                    Destroy(collision.gameObject);
                }
                break;
        }
    }

    public void PentagramEnds()
    {
        gameObject.SetActive(false);
    }
}
