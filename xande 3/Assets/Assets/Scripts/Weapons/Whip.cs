using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whip : WeaponBase
{
    public int damageMin, damageMax;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            int finalDamage = Random.Range(damageMin, damageMax + 1);

            if (Random.Range(0, 100) <= 20)
            {
                collision.GetComponent<Enemy>().TakeDamage(finalDamage * 2);
                print("critico");
            }
            else
            {
                collision.GetComponent<Enemy>().TakeDamage(finalDamage);
            }

            print(finalDamage);
        }
    }

}
