using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndWhenCollision : MonoBehaviour
{
    // Start is called before the first frame updat
   private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("end");
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))  {
                    SceneManager.LoadScene("WinScene");

        }
   }
}
