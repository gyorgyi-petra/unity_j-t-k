using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatar : MonoBehaviour {

    public Transform player;
    public float maxdistance;
    
    void Start()
    {

    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) >= maxdistance)
        {
            player.position = transform.position;
            player.GetComponent<playercontroller>().nullspeed();
        }
    }
}
