using HECSFramework.Core;
using System;

namespace Components
{
    [Serializable]
    [Documentation(Doc.Character, "Holds the character movement speed")]
    public class MovementSpeedComponent : BaseComponent
    {
        public float Speed;
    }
}