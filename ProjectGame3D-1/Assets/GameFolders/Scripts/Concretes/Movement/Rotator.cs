using System.Collections;
using System.Collections.Generic;
using ProjectGame3D.Controllers;
using UnityEngine;

namespace ProjectGame3D.Movement
{
    public class Rotator
{
    Rigidbody _rigidbody;
    PlayerController _playerController;
    public Rotator(PlayerController playerController)
    {
        _playerController = playerController;
        _rigidbody = playerController.GetComponent<Rigidbody>();
    }

    public void FixedTick(float direction)
    {
        
    }
}
}