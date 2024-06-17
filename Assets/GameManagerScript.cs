using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public string nextSceneName_;
    [SerializeField] private GameObject[] itemObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        IsClear();
    }

    private void IsClear()
    {
        for (int i = 0; i < itemObject.Length; i++)
        {
            if (itemObject[i] != null) { return; }
        }

        Debug.Log("clear"); 
        SceneManager.LoadScene(nextSceneName_);
    }
}
