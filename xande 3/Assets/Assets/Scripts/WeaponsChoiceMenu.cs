using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.Events;

public class WeaponsChoiceMenu : MonoBehaviour
{
    public TMP_Text[] weaponName = new TMP_Text[4];
    GameObject[] choicedWeapons = new GameObject[4];
    public UnityEvent OnLuck;
    void Start()
    {
        List<GameObject> weapons = Database.Instance.weapons.ToList();
        for (int i = 0; i < weaponName.Length; i++)
        {
            int randomNumber = Random.Range(0, weapons.Count);
            choicedWeapons[i] = weapons[randomNumber];
            weapons.RemoveAt(randomNumber);
            weaponName[i].text = choicedWeapons[i].name;

            if (i == 2)
            {
                if (PlayerStats.luck == 0)
                    return;

                if(Random.Range(0, 100) < 1 - 1/PlayerStats.luck)
                {
                    OnLuck.Invoke();
                }
                else
                {
                    break;
                }
            }
        }
    }

    public void WeaponChoosed(int id)
    {
        if (PlayerWeapons.Instance.weapons.Count == 0)
        {
            Instantiate(choicedWeapons[id], PlayerStats.Instance.weapons);
            PlayerWeapons.Instance.weapons.Add(choicedWeapons[id]);
            return;
        }
        for (int i = 0; i < PlayerWeapons.Instance.weapons.Count; i++)
        {
            if (PlayerWeapons.Instance.weapons[i].name.Equals(choicedWeapons[id].name))
            {//Achou a arma na lista já
                print("foi coletado já");
                break;
            }
            else
            {//Caso não seja a arma certa
                if (i == PlayerWeapons.Instance.weapons.Count - 1)
                {//Caso não seja a arma certa e esteja no último elemento da lista
                    Instantiate(choicedWeapons[id], PlayerStats.Instance.weapons);
                    PlayerWeapons.Instance.weapons.Add(choicedWeapons[id]);
                    break;
                }
            }
        }
    }
}
