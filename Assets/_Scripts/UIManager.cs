using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;
    public GameObject bnGameOver;
    private void Awake()
    {
        UIManager.instance = this;
        this.bnGameOver = GameObject.Find("bnGameOver");
        this.bnGameOver.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
