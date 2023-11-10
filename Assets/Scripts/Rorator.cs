using UnityEngine;

public class Rorator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;
    private Vector3 _vector;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _vector = new Vector3(0, _speed, 0) * Time.deltaTime;
    }

    private void Update()
    {
        _transform.Rotate(_vector);
    }
}
