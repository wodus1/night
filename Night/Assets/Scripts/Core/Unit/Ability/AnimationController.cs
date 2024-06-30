using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class AnimationController : MonoBehaviour
    {
        public enum AnimationState
        {
            Idle,
            Walk,
            Attack,
            Death,
        }

        private Animator _animator;
        private AnimationState _currentState;

        private void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            _currentState = AnimationState.Idle;
        }

        public void ChangeState(AnimationState newState)
        {
            switch(newState)
            {
                case AnimationState.Idle:
                    if (_currentState == newState)
                    {
                        _animator.SetBool("Walk", false);
                        _animator.SetBool("Attack", false);
                        return;
                    }
                    break;
                case AnimationState.Walk:
                    if (_currentState == newState)
                    {
                        _animator.SetBool("Walk", true);
                        _animator.SetBool("Attack", false);
                        return;
                    }
                    break;
                case AnimationState.Attack:
                    if (_currentState == newState)
                    {
                        _animator.SetBool("Walk", false);
                        _animator.SetBool("Attack", true);
                        return;
                    }
                    break;
                case AnimationState.Death:
                    if (_currentState == newState)
                    {
                        _animator.SetBool("Walk", false);
                        _animator.SetBool("Attack", false);
                        _animator.SetTrigger("Death");
                        return;
                    }
                    break;
            }
            _currentState = newState;
        }
    }
}

