using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleprefab;

    private Rigidbody rb_;
    private Vector3 clickPosition_;
    [SerializeField, Header("パワー")] private float power_=10;

    private bool isCanJump = false;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
    Physics.gravity=new Vector3(0,-9.8f,0);
        rb_ = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        particleprefab.transform.position = transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            clickPosition_=Input.mousePosition;
        }

       if(isCanJump&&Input.GetMouseButtonUp(0))
        {
            Vector3 dist=clickPosition_ - Input.mousePosition;
            if (dist.sqrMagnitude == 0) { return; }
            rb_.velocity=dist.normalized*power_;
            ShotCountScript.shotCounter++;
            particleprefab.Play();
            particleprefab.transform.LookAt(dist);
            audioSource.Play();
            //GameObject particleObj= Instantiate(particleprefab);
            //particleObj.transform.position=transform.position;

            //particleObj.transform.LookAt(dist);
        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("接触した");
        //isCanJump = true;
    }
    private void OnCollisionStay(Collision collision)
    {
        ContactPoint[] contacts= collision.contacts;
        Vector3 otherNormal = contacts[0].normal;
        Vector3 upVector=new Vector3(0,1,0);

        float dotUN=Vector3.Dot(otherNormal, upVector);
        float dotDeg=Mathf.Acos(dotUN)*Mathf.Rad2Deg;

        if(dotDeg<=45)
        {
            isCanJump = true;
        }
        //Debug.Log("接触している");
    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("離れた");
        isCanJump = false;
    }


}
