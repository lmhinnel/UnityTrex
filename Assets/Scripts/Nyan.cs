using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nyan : MonoBehaviour
{
    public float y = 5f;
    public bool Jumping;
    // Start is called before the first frame update
    void Start()
    {
        Jumping = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Jumping == false)
        {
            Jumping = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, y);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Finish") Jumping = false;
        if (coll.gameObject.tag == "Respawn") SceneManager.LoadScene("respawnScene");
    }
}
