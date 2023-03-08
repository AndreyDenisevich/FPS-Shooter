using System;
using System.Collections.Generic;
using Commands;
using Components;
using HECSFramework.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Systems
{
    [Documentation(Doc.Character, "System controls the character movement")]
    public sealed class PlayerCharacterMovementSystem : BaseSystem, IReactCommand<InputCommand>, IReactCommand<InputEndedCommand>
    {
        [Required] public MovementSpeedComponent MovementSpeedComponent;
        [Required] public UnityRigidbodyComponent UnityRigidbodyComponent;
        public override void InitSystem()
        {
        }

        public void CommandReact(InputCommand command)
        {
            if (command.Index == InputIdentifierMap.Movement)
            {
                Move(command.Context.ReadValue<Vector3>());
            }
        }

        public void CommandReact(InputEndedCommand command)
        {
            if (command.Index == InputIdentifierMap.Movement)
            {
                StopMove();
            }
        }
        private void Move(Vector3 direction)
        {
            UnityRigidbodyComponent.Rigidbody.velocity = direction.normalized * MovementSpeedComponent.Speed;
        }

        private void StopMove()
        {
            UnityRigidbodyComponent.Rigidbody.velocity = Vector2.zero;
        }
    }
}