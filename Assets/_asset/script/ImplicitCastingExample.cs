using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ImplicitCastingExample : MonoBehaviour
{
    [SerializeField] private float floatNum;
    [SerializeField] private int num;
    [SerializeField] private string strNum;

    // Start is called before the first frame update
    void Start()
    {
        //ep kieu ngam dinh(ko mat du lieu)
        // chuyen doi kieu du lieu 
        num = 10;
        floatNum = num; 
        Debug.Log("int to float: " + floatNum);

        //ep kieu tuong minh(co the mat du lieu)
        floatNum = 20.9f;
        num = (int)floatNum;
        Debug.Log("float to int: " + num);

        strNum = "123";
        num = int.Parse(strNum); // chuyen tu string qua int
        Debug.Log("Parsed Number: " + num);

        strNum = "123.456";
        floatNum = float.Parse(strNum);// chuyen tu string qua float
        Debug.Log("Parsed (float) Number: " + floatNum);
        
        strNum = "123.45";
        floatNum = Convert.ToSingle(strNum); // giong parse
        Debug.Log("Converted Float Number: " + floatNum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
