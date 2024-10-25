using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectAlias = System.Collections.Generic.Dictionary<string, int>;


public class AliasExample : MonoBehaviour
{
    [SerializeField] private ProjectAlias myDictionary;
    // Start is called before the first frame update
    void Start()
    {
        //tao 1 tenn
        myDictionary = new ProjectAlias();
        myDictionary["Key1"] = 1;
        myDictionary["Key2"] = 2;

        Debug.Log("Value for Key1: " + myDictionary["Key1"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
