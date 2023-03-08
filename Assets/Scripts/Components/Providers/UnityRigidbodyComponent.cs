using HECSFramework.Core;
using System;
using HECSFramework.Unity;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Components
{
    [Serializable]
    [Documentation(Doc.Provider, "Provides access to rigidbody")]
    public class UnityRigidbodyComponent : BaseComponent, IInitable
    {
        [ReadOnly] public Rigidbody Rigidbody;
        public void Init()
        {
            Owner.AsActor().TryGetComponent(out Rigidbody);
        }
    }
}