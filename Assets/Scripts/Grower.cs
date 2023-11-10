using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();        
    }

    private void Update()
    {
        float scale = _speed * Time.deltaTime;

        _transform.localScale += new Vector3(scale, scale, scale);
    }
}
