using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class car_ki_mummy : MonoBehaviour
{
    
    public Vector3 carPosition;
    public float carSpeed = 5f;
    public float maxLeft, maxRight;

    public AudioSource source;
    public AudioClip clip;


    void Start()
    {
        carPosition= transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        carPosition.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp (carPosition.x, maxLeft, maxRight);
        carPosition.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        carPosition.y = Mathf.Clamp(carPosition.y, -8.3f, 0.1f);
        transform.position = carPosition;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy_ki_mummy")
        {
            source.PlayOneShot(clip);

            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("randScore", 0));
            
            Thread.Sleep(500);
            
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
