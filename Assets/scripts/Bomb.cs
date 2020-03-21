using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour

{

    public Player player;
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Bomb");
        //collider = Physics.OverlapSphere(Transform.Position,5f);
       // Destroy(collider);
    }

}
