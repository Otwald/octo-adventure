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
        dir.x = Convert.ToUInt16(Input.IsActionJustPressed("ui_right")) - Convert.ToInt16(Input.IsActionPressed("ui_left"));
        dir.y = Convert.ToUInt16(Input.IsActionJustPressed("ui_down")) - Convert.ToInt16(Input.IsActionPressed("ui_up"));
        GD.Print(dir);
        return dir.Normalized();
    }
}
