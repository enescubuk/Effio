using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positionControl : MonoBehaviour
{
    public Text coinText;
    private int coin=120;
    public GameObject panel;
    //public Camera camera;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            panel.SetActive(true);
            panel.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            panel.transform.position = new Vector3(panel.transform.position.x,panel.transform.position.y,0);
            Debug.Log(Input.mousePosition);
            
        }
        coinText.text = "" + coin;
    }

    public void path1()
    {
        coin -= 50;
        panel.SetActive(false);
    }
    public void path2()
    {
        coin -= 50;
        panel.SetActive(false);
    }
    public void path3()
    {
        coin -= 50;
        panel.SetActive(false);
    }
    public void path4()
    {
        coin -= 90;
        panel.SetActive(false);
    }
    public void path5()
    {
        coin -= 90;
        panel.SetActive(false);
    }
    public void path6()
    {
        coin -= 90;
        panel.SetActive(false);
    }
    public void path7()
    {
        coin -= 30;
        panel.SetActive(false);
    }
    public void path8()
    {
        coin -= 30;
        panel.SetActive(false);
    }
    public void path9()
    {
        coin -= 30;
        panel.SetActive(false);
    }
    public void path10()
    {
        coin -= 120;
        panel.SetActive(false);
    }
}
