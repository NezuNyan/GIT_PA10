using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float speed;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(new Vector3(0, 1, 0) * speed * Time.deltaTime);
            thisAnimation.Play();


        }

        if (transform.position.y <= -5)
        {
            SceneManager.LoadScene(0);
        }
    }
}
