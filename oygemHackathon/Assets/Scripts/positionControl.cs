using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positionControl : MonoBehaviour
{
    public Text coinText;
    private int coin=120;
    public Ray selectedTiled;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Camera.main.ScreenPointToRay(Input.mousePosition));
            selectedTiled = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(selectedTiled);
            
        }

        coinText.text = "" + coin;
    }

    public void path1()
    {
        coin -= 50;

    }
    public void path2()
    {
        
        coin -= 50;
        
    }
    public void path3()
    {
        coin -= 50;
        
    }
    public void path4()
    {
        coin -= 90;
        
    }
    public void path5()
    {
        coin -= 90;
        
    }
    public void path6()
    {
        coin -= 90;
        
    }
    public void path7()
    {
        
        coin -= 30;
        
    }
    public void path8()
    {
        
        coin -= 30;
        
    }
    public void path9()
    {
       
        coin -= 30;
        
    }
    public void path10()
    {
       
        coin -= 120;

    }
}
