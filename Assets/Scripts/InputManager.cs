using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pacman;
    private Tweener tweener;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        animator = pacman.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pacman.transform.position == new Vector3(-9.48f, 5.48f, 0.0f))
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, new Vector3(-9.51f, 1.52f, 0.0f), 1.5f);
            animator.Play("Base Layer.PacStudent_Walking_Down");
        }
            
        if (pacman.transform.position == new Vector3(-9.51f, 1.52f, 0.0f))
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, new Vector3(-14.52f, 1.45f, 0.0f), 1.5f);
            animator.Play("Base Layer.PacStudent_Walking");
        }
            
        if (pacman.transform.position == new Vector3(-14.52f, 1.45f, 0.0f))
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, new Vector3(-14.39f, 5.4f, 0.0f), 1.5f);
            animator.Play("Base Layer.PacStudent_Walking_Up");
        }
            
        if (pacman.transform.position == new Vector3(-14.39f, 5.4f, 0.0f))
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, new Vector3(-9.48f, 5.48f, 0.0f), 1.5f);
            animator.Play("Base Layer.PacStudent_Walking_Right");
        }
            
    }
}
