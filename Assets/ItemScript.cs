using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleprefab;

    private Animator m_Animator;
    private AudioSource m_AudioSource;
    private bool isPlaySE = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator=GetComponent<Animator>();
        m_AudioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        m_Animator.SetTrigger("Get");
        if(!isPlaySE) m_AudioSource.Play();
        particleprefab.Play();
        isPlaySE = true;
     //   DestroySelf();

    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
