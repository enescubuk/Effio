using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positionControl : MonoBehaviour
{
    public Text coinText;
    private int coin=120;
    public Ray selectedTiled;
    public GameObject selectedTiledCanvas;
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
            selectedTiledCanvas.SetActive(false);
        }

        coinText.text = "" + coin;
    }

    public void path1()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 50;

    }
    public void path2()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 50;
        
    }
    public void path3()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 50;
        
    }
    public void path4()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 90;
        
    }
    public void path5()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 90;
        
    }
    public void path6()
    {
        selectedTiledCanvas.gameObject.SetActive(false); 
        coin -= 90;
        
    }
    public void path7()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 30;
        
    }
    public void path8()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 30;
        
    }
    public void path9()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 30;
        
    }
    public void path10()
    {
        selectedTiledCanvas.gameObject.SetActive(false);
        coin -= 120;

    }
}
