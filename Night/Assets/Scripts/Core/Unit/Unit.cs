using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [RequireComponent(typeof(AnimationController))]
    [RequireComponent(typeof(MoveAbility))]
    public abstract class Unit : MonoBehaviour
    {
        [SerializeField] private Transform _projectilePoint;
        
        protected AnimationController _animationController;
        protected MoveAbility _moveAbility;
        
        public Transform ProjectilePoint => _projectilePoint;
        
        public AnimationController AnimationController => _animationController;
        public MoveAbility MoveAbility => _moveAbility;
        
        protected virtual void Awake()
        {
            _moveAbility = GetComponent<MoveAbility>();
            _animationController = GetComponent<AnimationController>();
        }
    }
}

