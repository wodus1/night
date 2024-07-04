using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class EnemySystem : MonoBehaviour, ISubSystem
    {
        private List<EnemyUnit> _enemys = new List<EnemyUnit>();
        public void Initialize()    
        {
            _enemys.Clear();
        }

        public void Deinitialize()
        {
            _enemys.Clear();
        }

        internal void AddEnemy(EnemyUnit enemy)
        {
            _enemys.Add(enemy);
        }

        internal void RemoveEnemy(EnemyUnit enemy)
        {
            _enemys.Remove(enemy);
        }

        internal int EnemysCount()
        {
            return _enemys.Count;
        }
    }
}
