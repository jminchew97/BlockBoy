using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 playerCoords = new Vector2();



    //Get components
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] playerSprites;


    // Start is called before the first frame update
    void Start()
    {
        
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        playerCoords = transform.position;

    }



    // Update is called once per frame
    void Update()
    {
        getPlayerInput();
        movePlayer();

    }

    public bool didBlockBoyMove()
    {
        if (Input.anyKeyDown)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void movePlayer()
    {
        playerCoords.x = Mathf.Clamp(playerCoords.x, -4.5f, 4.5f);
        playerCoords.y = Mathf.Clamp(playerCoords.y, -4.5f, 4.5f);

        // Set coords to player object
        transform.position = playerCoords;
    }

    private void getPlayerInput()
    {
        // Get inputs
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerCoords.y += 1;
            spriteRenderer.sprite = playerSprites[0];
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            playerCoords.y -= 1;
            spriteRenderer.sprite = playerSprites[2];
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            playerCoords.x += 1;
            spriteRenderer.sprite = playerSprites[1];
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            playerCoords.x -= 1;
            spriteRenderer.sprite = playerSprites[3];
        }
    }
}
