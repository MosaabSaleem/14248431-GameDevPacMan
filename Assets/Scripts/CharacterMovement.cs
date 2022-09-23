using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 movement; 
    private float movementSqrMagnitude;
    public float walkSpeed = 1.75f;
    public Animator playerAnimator;
    public AudioSource footstepSource;
    public AudioClip[] footstepClips;
    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void GetMovementInput() 
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        Vector3.ClampMagnitude(movement, 1.0f);
        movementSqrMagnitude = movement.sqrMagnitude;
    } 
    void CharacterPostion() 
    {
        transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);
    } 
    void CharacterRotation() 
    {
        if (movement != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(movement);
    } 
    void WalkAnimation()
    {
        playerAnimator.SetFloat("MovingSpeed", movementSqrMagnitude);
        
    } 
    void FootstepAudio() 
    { 
        if (movementSqrMagnitude > 0.25 && !footstepSource.isPlaying)
        {
            if (footstepSource.clip == footstepClips[0])
                footstepSource.clip = footstepClips[1];
            else
                footstepSource.clip = footstepClips[0];

            footstepSource.volume = movementSqrMagnitude;
            footstepSource.Play();
            backgroundMusic.volume = 0.5f;
        }
        else if (movementSqrMagnitude < 0.3f && footstepSource.isPlaying)
        {
            footstepSource.Stop();
            backgroundMusic.volume = 1.0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit: " + other.name + " : " + other.transform.position.ToString());
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter: " + collision.contacts[0].otherCollider.name + " : " + collision.transform.position.ToString());
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Impassable"))
            Debug.Log("Collision Stay: " + collision.gameObject.name);
    }

    bool RaycastCheck()
    {
        RaycastHit hit = new RaycastHit();

        if (hit.collider == null)
            hit = new RaycastHit();

        if (Physics.Raycast(transform.position + new Vector3(0, 1, 0), Vector3.forward, out hit, 5.0f))
            Debug.Log("Raycast hit:" + hit.collider.name);
        if (hit.collider.CompareTag("Freeze"))
            return true;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        GetMovementInput();
        CharacterPostion();
        CharacterRotation();
        WalkAnimation();
        FootstepAudio();
        if (RaycastCheck())
        {
            playerAnimator.enabled = false;
            footstepSource.Stop();
            backgroundMusic.Stop();
            //transform.
        }


    }
}
