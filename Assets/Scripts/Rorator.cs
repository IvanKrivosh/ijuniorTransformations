using UnityEngine;

public class Rorator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;    

    private void Awake()
    {
        _transform = GetComponent<Transform>();        
    }

    private void Update()
    {
        _transform.Rotate(new Vector3(0, _speed * Time.deltaTime, 0));
    }
}
