using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinChocolat : Lutin
{
    public override void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }

    public override void Interact(Player player)
    {
        Debug.Log("Lutin Chocolat");
    }

    void Start()
    {
    }

    void Update()
    {
        
    }
}
