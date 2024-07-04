using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [RequireComponent(typeof(AgentMoveAbility))]

    public class AgentUnit : Unit
    {
        private AgentData _agent;
        private AgentMoveAbility _moveAbility;
        public AgentData Agent => _agent;
        public AgentMoveAbility MoveAbility => _moveAbility;
        protected override void Awake()
        {
            base.Awake();
            _moveAbility = GetComponent<AgentMoveAbility>();
        }

        internal void Initialize(AgentData agent)
        {
            _agent = agent;
            _moveAbility.Initialize(this);
        }
    }
}

