using Godot;
using System;

public abstract class PlayerState : State
{
    [Export] public int speed = 500;
    public Vector2 velocity = new Vector2();
    Node player;
    public Vector2 GetInput()
    {
        Vector2 dir = new Vector2(0, 0);
        if (Input.IsActionPressed("ui_right"))
        {
            dir.x += speed;
        }
        if (Input.IsActionPressed("ui_left"))
        {
            dir.x -= speed;
        }
        if (Input.IsActionPressed("ui_up"))
        {
            dir.y -= speed;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            dir.y += speed;
        }
        return dir.Normalized();
    }
}
