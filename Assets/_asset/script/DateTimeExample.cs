using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DateTimeExample : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime specificDate;
    [SerializeField] private TimeSpan duration;
    // Start is called before the first frame update
    void Start()
    {
        now = DateTime.Now; //ngay, gio hien tai
        specificDate = new DateTime(2024, 10, 23); //ngay cu the, mac dinh 0h 
        Debug.Log("Ngay va gio hien tai: " + now);
        Debug.Log("Ngay cu the: " + specificDate);

        DateTime addDay;
        addDay = now.AddDays(10); // them so ngay cu the
        Debug.Log("Ngay sau khi them 10 day: " + addDay);

        DateTime addMonth;
        addMonth = now.AddMonths(2); // them so thang cu the
        Debug.Log("Ngay sau khi them 2 thang: " + addMonth);

        //dinh dang thu ngay thang cu the
        Debug.Log("Ngay hien tai (String): " + now.ToString("dd-MM-yyyy"));

        //thoi gian tu hqua toi hnay
        TimeSpan a = now - specificDate;
        //Double A = a.TotalDays;
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
