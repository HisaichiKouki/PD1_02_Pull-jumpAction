using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        m_Animator.SetTrigger("Get");
     //   DestroySelf();

    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}