using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class UnitCreateSystem : MonoBehaviour, ISubSystem
    {
        private AgentSystem _agentSystem;
        private EnemySystem _enemySystem;
        public void Initialize()
        {
            _agentSystem = GameManager.Instance.GetSubSystem<AgentSystem>();
            _enemySystem = GameManager.Instance.GetSubSystem<EnemySystem>();
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

        internal void CreateEnemy(EnemyData data)
        {
            var template = data.template;
            var enemyInstance = Instantiate(template.prefab, transform);
            enemyInstance.transform.position += new Vector3(5, 0, 2);
            EnemyUnit enemy = enemyInstance.GetComponent<EnemyUnit>();
            enemy.Initialize(data);
            _enemySystem.AddEnemy(enemy);
        }
    }
}

