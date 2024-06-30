using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Night.Core
{
    public class MoveAbility : MonoBehaviour
    {
        private AgentUnit _agentUnit;
        private NavMeshAgent _navMeshAgent;
        private float[] _moveDistnace = new float[] { 4.0f, -4.0f };
       
        internal void Initialize(AgentUnit agentUnit)
        {
            this._agentUnit = agentUnit;
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {

            if (Vector3.Distance(transform.position, _navMeshAgent.destination) < 0.1f)
            {
                _agentUnit.AnimationController.ChangeState(AnimationController.AnimationState.Idle);
                Invoke("MovePos", 0.5f);
            }

        }

        private void MovePos()
        {
            _agentUnit.AnimationController.ChangeState(AnimationController.AnimationState.Walk);
            _navMeshAgent.SetDestination(new Vector3(transform.position.x + _moveDistnace[Random.Range(0, _moveDistnace.Length)], 0, 
                transform.position.z + _moveDistnace[Random.Range(0, _moveDistnace.Length)]));
        }

    }
}
