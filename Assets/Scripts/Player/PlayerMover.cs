using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movespeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;

    private Vector3 _targetposition;

    private void Start()
    {
        _targetposition = transform.position;
    }

    private void Update()
    {
        if(transform.position != _targetposition)
        {
            transform.position = Vector3.MoveTowards(transform.position,_targetposition, _movespeed*Time.deltaTime);
        }
    }
    
    public void TryMoveup()
    {
        if(_targetposition.y < _maxHeight)
        SetNextPosition(_stepSize);
    }
    public void TryMoveDown()
    {
        if(_targetposition.y > _minHeight)
        SetNextPosition(-_stepSize);
    }

    private void SetNextPosition(float stepSize)
    {
        _targetposition = new Vector2(_targetposition.x, _targetposition.y + stepSize);
    }
}
