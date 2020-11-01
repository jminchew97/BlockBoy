using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] CircleGirl circleGirl;
    Player player;
    Vector2 position = new Vector2();


    // Changable Properties
    [SerializeField]int maxEnemies = 5;
    // Start is called before the first frame update
    void Start()
    {
        // Get Objects
        player = FindObjectOfType<Player>();

        
        for (int i = 0;i < maxEnemies; i++)
        {
            position.x = Mathf.Round(Random.Range(-4.5f, 4.5f)) + .5f;
            position.y = Mathf.Round(Random.Range(-4.5f, 4.5f)) + .5f;
            Instantiate(circleGirl, position, transform.rotation);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
