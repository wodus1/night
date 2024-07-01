using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class UnitCreateSystem : MonoBehaviour, ISubSystem
    {
        private AgentSystem _agentSystem;
        public void Initialize()
        {
            _agentSystem = GameManager.Instance.GetSubSystem<AgentSystem>();
        }

        public void Deinitialize()
        {

        }

        internal void CreateAgent(AgentData data)
        {
            var template = data.template;
            var agentInstance = Instantiate(template.prefab, transform);
            AgentUnit agent = agentInstance.GetComponent<AgentUnit>();
            agent.Initialize(data);
            _agentSystem.AddAgent(agent);
        }
    }
}

