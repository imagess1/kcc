using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turntable : MonoBehaviour
{
    public GameObject GO;
    private int number; //计数
    private bool isTrigger; //判断游戏是否结束
    public Transform tran;
    public Text text;       //显示计数

    // Start is called before the first frame update
    void Start()
    {
        isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrigger)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(GO, tran.transform.position, Quaternion.identity);
            }
            transform.Rotate(Vector3.back, Time.deltaTime * 10f);
        }
    }


    public void OnNumber()
    {
        number++;
        text.text = number.ToString();
    }

    public void OnTriggetr()
    {
        isTrigger = false;
    }

}
