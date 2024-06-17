using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    int a;
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            a++;
            SceneManager.LoadScene("TitleScene");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("TitleScene");

        }
    }
}
