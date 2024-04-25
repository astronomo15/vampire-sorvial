using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public static Database Instance;
    public GameObject[] weapons;
    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        
    }
}
