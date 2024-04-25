using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    public static PlayerWeapons Instance;
    public List<GameObject> weapons = new List<GameObject>();
    void Start()
    {
        Instance = this;
    }


    void Update()
    {
        
    }
}
