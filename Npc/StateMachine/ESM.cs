using Godot;
using System;

namespace NPC
{
    public class ESM : StateMaschine
    {
        public Npc self;
        public override void _Ready()
        {
            base._Ready();
            this.stateMap.Add("talk", GetNode("Talk") as State);
            this.self = GetParent<Npc>() as Npc;
        }
    }
}
