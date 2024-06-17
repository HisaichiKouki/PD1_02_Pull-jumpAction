using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotCountScript : MonoBehaviour
{

     public static int shotCounter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.gameObject.GetComponent<Text>().text = "ƒVƒ‡ƒbƒg‰ñ”:" + shotCounter.ToString();
    }
}
