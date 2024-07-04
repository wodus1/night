using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Night.Core
{
    public class AgentMoveAbility : MoveAbility
    {
        private AgentUnit _agentUnit;
        private NavMeshAgent _navMeshAgent;
        private AgentSystem _agentSystem;
        private float[] _moveDistnace = new float[] { 4.0f, -4.0f };

        public override void Initialize(Unit agentUnit)
        {
            this._agentUnit = agentUnit as AgentUnit;
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _agentSystem = GameManager.Instance.GetSubSystem<AgentSystem>();
        }

        private void Update()
        {
            if (_agentSystem.GetMainAgent() == _agentUnit)
            {
                if (Vector3.Distance(transform.position, _navMeshAgent.destination) < 0.1f)
                {
                    _agentUnit.AnimationController.ChangeState(AnimationController.AnimationState.Idle);
                    if (_agentSystem.GetMainAgent() == _agentUnit)
                        Invoke("Move", 1f);
                }
            }

            if (_agentSystem.GetMainAgent() != _agentUnit)
            {
                if (Vector3.Distance(transform.position, _agentSystem.GetMainAgent().transform.position) < 2f)
                {
                    _agentUnit.AnimationController.ChangeState(AnimationController.AnimationState.Idle);
                    _navMeshAgent.ResetPath();
                }
                else
                {
                    _agentUnit.AnimationController.ChangeState(AnimationController.AnimationState.Walk);
                    _navMeshAgent.SetDestination(_agentSystem.GetMainAgent().transform.position);
                }
            }
        }

        private void Move()
        {
            _agentUnit.AnimationController.ChangeState(AnimationController.AnimationState.Walk);

            _navMeshAgent.SetDestination(new Vector3(transform.position.x + _moveDistnace[Random.Range(0, _moveDistnace.Length)], 0,
                transform.position.z + _moveDistnace[Random.Range(0, _moveDistnace.Length)]));
        }
    }
}
