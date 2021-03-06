using Godot;
using System;

namespace Player
{
    public class PSM : StateMaschine
    {
        public Player player = null;

        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
            base._Ready();
            this.stateMap.Add("interact", GetNode("Interact") as State);
            this.player = GetParent<Player>();
        }

        //  // Called every frame. 'delta' is the elapsed time since the previous frame.
        //  public override void _Process(float delta)
        //  {
        //      
        //  }
    }
}