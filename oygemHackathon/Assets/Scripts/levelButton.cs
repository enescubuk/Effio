using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelButton : MonoBehaviour
{
    public levelSelectMenu menu;
    public Sprite lockSprite;
    public Sprite buttonSprite;
    public Text levelText;

    private int level = 0;
    private Button button;
    private Image image;

    void OnEnable()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
    }

    private void Start()
    {
        
    }

    public void Setup(int level, bool isUnlock)
    {
        this.level = level;
        levelText.text = level.ToString();

        if (isUnlock)
        {
            gameObject.transform.localScale = new Vector3(0.67929f, 0.67929f, 0.67929f);
            image.sprite = buttonSprite;
            button.enabled = true;
            levelText.gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            image.sprite = lockSprite;
            button.enabled = false;
            levelText.gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        menu.StartLevel(level);
    }
}
