using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IMovementData
{
    Vector3 CurrentVelocity { get; }
    bool OnGround { get; }

}
