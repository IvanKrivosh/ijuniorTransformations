using UnityEngine;

public class Mover : MonoBehaviour
{  
	[SerializeField] private float _speed;

    private Transform _transform;
    private Vector3 _vector;

    private void Awake()
	{
		_transform = GetComponent<Transform>();
        _vector = new Vector3(_speed * Time.deltaTime, 0, 0);
    }

	private void Update()
	{
        transform.position = transform.position + _vector;
    }
}
