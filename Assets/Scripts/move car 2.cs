using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCarTwo : MonoBehaviour
{
    private Vector3 pos;
    [SerializeField] private float speed = -3f;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos + new Vector3(12, 0, 0) * Mathf.Sin(Time.time * speed);

    }
}
