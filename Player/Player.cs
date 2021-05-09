using Godot;
using System;

public class Player : KinematicBody2D
{
    [Export] public int speed = 500;
    [Signal] public delegate void Detach();
    [Signal] public delegate void OnGround();
    [Signal] public delegate void OnKick();

    private bool controll = false;
    public Vector2 velocity = new Vector2();


    // Called when the node enters the scene tree for the first time.
    // public override void _Ready()
    // {

    // }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        this.GetInput();
        velocity = MoveAndSlide(velocity);
    }

    private void GetInput()
    {
        velocity = new Vector2(0, 0);
        if (Input.IsActionPressed("ui_right"))
        {
            velocity.x += speed;
        }
        if (Input.IsActionPressed("ui_left"))
        {
            velocity.x -= speed;
        }
        if (Input.IsActionPressed("ui_up"))
        {
            velocity.y -= speed;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            velocity.y += speed;
        }
    }
}
