using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TimeSpanExample : MonoBehaviour
{
    [SerializeField] private TimeSpan duration;

    // Start is called before the first frame update
    void Start()
    {
        duration = new TimeSpan(1, 30, 0); // 1h30p | tao 1 khoang thoi gian cu the
        Debug.Log("Khoang thoi gian: " + duration);

        TimeSpan motNuaNam = TimeSpan.FromDays(365 / 2);//tao ra so ngay cu the
        Debug.Log("So ngay cu the: " + motNuaNam);

        TimeSpan gioToDay = TimeSpan.FromHours(100);//tao ra so ngay, gio cu the tu gio nhap vao
        Debug.Log("So ngay + gio cu the: " + gioToDay); //hien thi: ngay.gio
        //tuong tu Minutes, Seconds


        Double tongPhut = duration.TotalMinutes; //quy doi ra phut
        Double tongGiay = duration.TotalSeconds; //quy doi ra giay
        //tuong tu hour, day,...
        Debug.Log($"Tong phut sau quy doi: {tongPhut} phut");
        Debug.Log($"Tong giay sau quy doi: {tongGiay}s");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
