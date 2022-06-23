using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectGame3D.Movement
{
public class PlayerMover
{
   Rigidbody _rigidbody;

   public PlayerMover(Rigidbody rigidbody)
   {
        _rigidbody = rigidbody;
   }

   public void FixedTick()
   {
        _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 55f);
   }
}    
}