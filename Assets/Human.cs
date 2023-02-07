using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Human
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public float Speed { get; set; }

    public void Say();

}
