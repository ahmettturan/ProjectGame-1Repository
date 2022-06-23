using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectGame3D.Inputs;
using ProjectGame3D.Movement;

namespace ProjectGame3D.Controllers 
{
public class PlayerController : MonoBehaviour
{
    private PlayerMover _playerMover;
    Rigidbody _rigidbody;
    DefaultInput _input;
    bool _isForceUp;
    private void Awake() 
    {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
            _playerMover = new PlayerMover(rigidbody:GetComponent<Rigidbody>());
    }
    private void Update() 
    {
        if (_input.IsForceUp)
        {
            _isForceUp = true;
        }
        else
        {
            _isForceUp = false;
        }
    }
    private void FixedUpdate() 
    {
        if(_isForceUp)
        {
            _playerMover.FixedTick();
        }
    }
}

}   
