using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public enum EJob
    {
        MeleeDealer,
        MagicDealer,
        RangedDealer,
        Healer
    }

    [CreateAssetMenu(menuName = "Nights/Templates/Job", fileName = "Job", order = 0)]
    public class JobTemplate : ScriptableObject
    {
        public EJob id;
        public string displayName;
        public EAttackMethod attackMethod;
    }
}

