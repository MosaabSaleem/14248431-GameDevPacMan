using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public GameObject pacman;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pacman.transform.Translate(pacman.transform.position * 0.4f * Time.deltaTime);
    }
}
