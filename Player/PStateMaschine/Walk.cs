using Godot;
using System;

namespace Player
{
    public class Walk : PlayerState
    {
        public override string UpdateProcess(StateMaschine sM, float delta)
        {
            if (this.GetInteractInput()) { return "interact"; }
            this.velocity = this.GetInput();
            if (this.velocity == new Vector2(0, 0)) { return "previous"; }
            Node2D rotHelp = this.player.GetNode("RotationHelper") as Node2D;
            rotHelp.Rotation = this.velocity.Angle();
            this.velocity = this.velocity * Player.MAX_SPEED;
            this.velocity = player.MoveAndSlide(this.velocity);
            return null;
        }
    }
}