using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    public float speed = 3f;
    public Vector2 direction;
    
    private void Start()
    {
        Destroy(this.gameObject, 3);
    }

    private void Update()
    {
        Vector2 movement = direction.normalized * speed * Time.deltaTime;
        
        transform.Translate(movement);
        
    }
}
