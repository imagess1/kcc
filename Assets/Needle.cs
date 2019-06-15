using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    private float speed = 15f;
    private Turntable _Turntable;
    // Start is called before the first frame update
    void Start()
    {
        _Turntable = GameObject.Find("Turnatble").GetComponent<Turntable>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            transform.parent = collision.transform;
            speed = 0;
            _Turntable.OnNumber();
        }
        else if (collision.collider.tag == "Need")
        {
            Camera.main.backgroundColor = Color.red;
            _Turntable.OnTriggetr();
        }
    }
}
