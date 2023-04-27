using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
//Game manager object
[Header("Game Controller Object for controlling the game")]
public GameController gameController;
[Header(""Defult Velocity")]
public float velocity = 5;
//Physics for the bird
private Rigidbody2D rb;
//hight of the bird object on the y axis
private float objectHeight;
void Start()
{
    //Game Controller componet
    gameController = GetController<GameController>();
    //Speed the game is at a playing state
    Time.timeScale = 1;
    rb = GetComponet<Rigidbody2D>();
    // Object Height equals the size of the height of the sprite
    objectHeight = transform.GetComponet<SpriteRenederer>().bounds.size.y / 2;
//If the left mouse button is clicked
if (Input.GetMouseButtonDown(0))
    {
        //The bird will float up on the Y axis
        //and float back down on the Y axis
        rb.velocity = Vector2.up * velocity;
    }
}