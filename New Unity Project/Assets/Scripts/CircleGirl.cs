using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CircleGirl : MonoBehaviour
{
    Vector2 girlCoords = new Vector2();
    Player blockBoy;
    private void Start()
    {
        
        // Set coords to current coords
        girlCoords = transform.position;

        
    }
    

    private void Update()
    {
        collisionBlockBoy();
        // Move
        moveCircleGirl();
    }
    private void moveCircleGirl()
    {
        if (blockBoy.didBlockBoyMove())
        {
            girlCoords.x -= 1;
            transform.position = girlCoords;
            Debug.Log("MOVE");
        }
    }
    private void collisionBlockBoy()
    {
        blockBoy = FindObjectOfType<Player>();
        if (blockBoy.playerCoords == girlCoords)
        {
            Debug.Log("Collision");
        }
    }
}
