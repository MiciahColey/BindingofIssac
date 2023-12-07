using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New PowerUp Data",menuName = "PowerUP Data")]
public class Powerupdata : ScriptableObject
{
    public IssacMovement player;

    [SerializeField]
    private  GameObject prefab;
    [SerializeField]
    private PowerupType powertype;


    public GameObject Prefab
    {
        get
        {
            return prefab;
        }
        set
        {
            prefab = value;
        }
    }

    public PowerupType PowerType
    {
        get
        {
            return powertype;
        }
        set
        {
            powertype = value;
        }
    }




}

public enum PowerupType
{
    none,
    Brimestone,
    Haemolacria,
    DoubleWiz
}
