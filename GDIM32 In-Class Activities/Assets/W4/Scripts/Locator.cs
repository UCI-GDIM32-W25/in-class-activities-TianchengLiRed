using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; set;}
    public W4Pigeon pigeon { get; set;}
    // Start is called before the first frame update
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject playObj = GameObject.FindGameObjectWithTag("Player");
        pigeon = playObj.GetComponent<W4Pigeon>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
