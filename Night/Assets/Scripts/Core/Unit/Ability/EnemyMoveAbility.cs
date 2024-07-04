using Night.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Night.Core
{
    public class EnemyMoveAbility : MoveAbility
    {
        private EnemyUnit _enemyUnit;
        private NavMeshAgent _navMeshAgent;
        private EnemySystem _enemySystem;
        private float[] _moveDistnace = new float[] { 2.0f, -2.0f };

        public override void Initialize(Unit enemyUnit)
        {
            this._enemyUnit = enemyUnit as EnemyUnit;
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _enemySystem = GameManager.Instance.GetSubSystem<EnemySystem>();
        }

        void Update()
        {
            if (Vector3.Distance(transform.position, _navMeshAgent.destination) < 0.1f)
            {
                _enemyUnit.AnimationController.ChangeState(AnimationController.AnimationState.Idle);
                Invoke("Move", 1f);
            }
        }

        private void Move()
        {
            _enemyUnit.AnimationController.ChangeState(AnimationController.AnimationState.Walk);

            _navMeshAgent.SetDestination(new Vector3(transform.position.x + _moveDistnace[Random.Range(0, _moveDistnace.Length)], 0,
                transform.position.z + _moveDistnace[Random.Range(0, _moveDistnace.Length)]));
        }
    }

}

