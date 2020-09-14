using UnityEngine;

public class PathFollower : MonoBehaviour
{
    // Dit is niet DRY én niet dynamisch...
    // kun je oplossen door een array te gebruiken
    [SerializeField] private Transform _targetA;
    [SerializeField] private Transform _targetB;
    [SerializeField] private Transform _targetC;
    
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalthreshold = 0.1f;

    private Transform _currentWaypoint;

    private void Start()
    {
        _currentWaypoint = _targetA;
    }

    private void Update()
    {
        Vector3 heightOffsetPosition = new Vector3(_currentWaypoint.position.x, transform.position.y, _currentWaypoint.position.z);
        float distance = Vector3.Distance(transform.position, heightOffsetPosition);
        
        if (distance <= _arrivalthreshold)
        {
            if (_currentWaypoint == _targetA)
            {
                _currentWaypoint = _targetB;
            }
            else if (_currentWaypoint == _targetB)
            {
                _currentWaypoint = _targetC;
            }
            else if (_currentWaypoint == _targetC)
            {
                print("Ik ben bij het eindpunt!");
            }
        }
        else
        {
            transform.LookAt(heightOffsetPosition);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);    
        }
    }
}
