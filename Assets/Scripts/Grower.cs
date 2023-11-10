using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;
    private Vector3 vector;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        vector = new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
    }

    private void Update()
    {        
        _transform.localScale += vector;
    }
}
