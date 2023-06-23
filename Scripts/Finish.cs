using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        Debug.Log("You Beat The Maze!");

    }

}
