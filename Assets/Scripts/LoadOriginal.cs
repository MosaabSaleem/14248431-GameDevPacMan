using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadOriginal : MonoBehaviour
{

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(gameObject);
        
    }

    public void message()
    {
        Debug.Log("pressed");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}