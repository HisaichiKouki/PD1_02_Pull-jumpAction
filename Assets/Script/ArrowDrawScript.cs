using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArrowDrawScript : MonoBehaviour
{
    public Image arrowTex_;
    private Vector3 clickPotition_;


    // Start is called before the first frame update
    void Start()
    {
        arrowTex_.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPotition_ = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            arrowTex_.gameObject.SetActive(true);

            Vector3 dist = clickPotition_ - Input.mousePosition;
            float size = dist.magnitude;
            float angleRad = Mathf.Atan2(dist.y, dist.x);
            arrowTex_.rectTransform.position = clickPotition_;
            arrowTex_.rectTransform.rotation=
                Quaternion.Euler(0,0,angleRad*Mathf.Rad2Deg);
            arrowTex_.rectTransform.sizeDelta=new Vector2(size,size);

        }


        if (Input.GetMouseButtonUp(0))
        {
            arrowTex_.gameObject.SetActive(false);

        }
    }
}
