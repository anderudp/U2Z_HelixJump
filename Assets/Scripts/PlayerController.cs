using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float jumpForce = 5f;
    private bool jumpOnCooldown = false;
    public static int level = 1;
    public static int bestLevel = 1;
    
    void OnCollisionEnter(Collision other)
    {
        if(!jumpOnCooldown)
        {
            if(other.gameObject.tag == "Finish")
            {
                level++;
                SceneManager.LoadScene("SampleScene");
            }
            if(other.gameObject.tag == "badPlatform")
            {
                if(level > bestLevel) bestLevel = level;
                level = 1;
                SceneManager.LoadScene("SampleScene");
            }

            jumpOnCooldown = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            StartCoroutine(ResetJump());
        }
    }

    IEnumerator ResetJump()
    {
        yield return new WaitForSeconds(0.1f);
        jumpOnCooldown = false;
    }
}
