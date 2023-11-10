using UnityEngine;

public class Mover : MonoBehaviour
{  
	[SerializeField] private float _speed;

    private Transform _transform;    

    private void Awake()
	{
		_transform = GetComponent<Transform>();        
    }

	private void Update()
	{
        _transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
