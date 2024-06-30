using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Waknights.Core
{
    public class GameManager : MonoBehaviour
    {
        private Dictionary<Type, ISubSystem> _subSystems = new Dictionary<Type, ISubSystem>();

        private void Awake()
        {
            var systems = GetComponentsInChildren<ISubSystem>(true);
            foreach (var system in systems)
            {
                _subSystems.Add(system.GetType(), system);
            }

            foreach (var system in this._subSystems.Values)
            {
                system.Initialize();
            }
        }
    }
}

