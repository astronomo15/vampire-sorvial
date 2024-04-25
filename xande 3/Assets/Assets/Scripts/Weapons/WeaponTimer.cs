using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponTimer : MonoBehaviour
{
    public UnityEvent OnTimerAttack;
    //public GameObject weapon;
    public float timerToActivate;

    float timer;
    void Start()
    {
        StartCoroutine(Activate());
    }


    void Update()
    {
        /*
        timer += Time.deltaTime;
        if (timer >= timerToActivate) 
        {
            ActiveWeapon();
            timer = 0;
        }
        */

    }

    IEnumerator Activate()
    {
        yield return new WaitForSeconds(timerToActivate);
        ActiveWeapon();
        StartCoroutine(Activate());
    }

    void ActiveWeapon()
    {
        //weapon.SetActive(true);
        OnTimerAttack.Invoke();
    }
}
