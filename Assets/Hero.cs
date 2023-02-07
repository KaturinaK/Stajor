using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour, Human
{
    private string name;
    private int hp;
    private float speed;
    public string Name { get { return name; } set { name = value; } }
    public int Hp { get { return hp; } set { hp = value; } }
    public float Speed { get { return speed; } set { speed = value; } }

    public void Say()
    {
        Debug.Log("hi");
    }

    void Start()
    {
        name = "ll";
        Say();
    }
}
