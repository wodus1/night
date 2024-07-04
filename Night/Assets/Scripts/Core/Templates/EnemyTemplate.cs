using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [CreateAssetMenu(menuName = "Nights/Templates/Enemy", fileName = "Enemy", order = 0)]
    public class EnemyTemplate : ScriptableObject
    {
        public int id;

        [Header("�⺻����")]
        public string displayName;
        public GameObject prefab;
        [Header("����")]
        public EAttackMethod attackMethod;
        public int maxHP;
        public int ATK;
        public int DEF;
        public float attackTerm;
        [Range(0, 10)]
        public float attackRange;

    }
}

