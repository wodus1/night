using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [RequireComponent(typeof(EnemyMoveAbility))]

    public class EnemyUnit : Unit
    {
        private EnemyData _enemy;
        private EnemyMoveAbility _moveAbility;
        public EnemyData Enemy => _enemy;
        public EnemyMoveAbility MoveAbility => _moveAbility;
        protected override void Awake()
        {
            base.Awake();
            _moveAbility = GetComponent<EnemyMoveAbility>();
        }

        internal void Initialize(EnemyData enemy)
        {
            _enemy = enemy;
            _moveAbility.Initialize(this);
        }
    }
}

