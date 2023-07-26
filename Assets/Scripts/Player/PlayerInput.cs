using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _Mover;

    private void Start()
    {
        _Mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            _Mover.TryMoveup();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            _Mover.TryMoveDown();
        }

    }

}
