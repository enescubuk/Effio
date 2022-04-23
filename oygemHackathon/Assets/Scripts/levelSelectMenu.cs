using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelectMenu : MonoBehaviour
{
    
    public int totalLevel = 0;
    public int unlockedLevel = 1;

    private levelButton[] LevelButtons; 
    private int totalPage = 0;
    private int page = 0;
    private int pageItem = 9;
    public GameObject nextButton;
    public GameObject backButton;
    
    void OnEnable()
    {
        LevelButtons = GetComponentsInChildren<levelButton>();
    }
    void Start()
    {
        Reflesh();
    }

    public void StartLevel(int level)
    {
        if (level==unlockedLevel)
        {
            unlockedLevel += 1;
            Reflesh();
        }
    }
    public void ClickNext()
    {
        page += 1;
        Reflesh();
    }
    public void ClickBack()
    {
        page -= 1;
        Reflesh();
    }

    public void Reflesh()
    {
        totalPage = totalLevel / pageItem;
        int index = page * pageItem;
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            int level = index + i + 1;
            if (level<=totalLevel)
            {
                LevelButtons[i].gameObject.SetActive(true);
                LevelButtons[i].Setup(level, level<= unlockedLevel);
            }
            else
            {
                LevelButtons[i].gameObject.SetActive(false);
            }
        }
        CheckButton();
    }

    private void CheckButton()
    {
        backButton.SetActive(page>0);
        nextButton.SetActive(page<totalPage);
    }
}
