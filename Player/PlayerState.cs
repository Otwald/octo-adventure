using Godot;
using System;

public abstract class PlayerState : State
{
    [Export] public int speed = 500;
    public Vector2 velocity = new Vector2();
    Node player;
    public void GetInput()
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
