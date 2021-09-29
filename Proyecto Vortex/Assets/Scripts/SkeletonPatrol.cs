using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonPatrol : MonoBehaviour
{
    // Gameobject Throwing action variables
    public GameObject bonePrefab;
    public GameObject thrower;
    private Transform _hand;
    
    // Start is called before the first frame update
    void Awake()
    {
        _hand = transform.Find("Hand");
    }

    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Throw();
            Debug.Log("Avente un gueso");
        }
    }

    public void Throw()
    {
        if (bonePrefab != null && _hand != null && thrower)
        {
            GameObject myBone = Instantiate(bonePrefab, _hand.position, Quaternion.identity);
            Bone boneComponent = myBone.GetComponent<Bone>();

            if (thrower.transform.localScale.x < 0f)
            {
                boneComponent.direction = Vector2.right;
            }
            else
            {
                boneComponent.direction = Vector2.left;
            }
        }
    }
}
