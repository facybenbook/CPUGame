﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButtonController : MonoBehaviour, IButton
{

    public static ClearButtonController instance;

    public TextMesh text;
    public SpriteRenderer background;

    private bool hover;

    void Start()
    {
        instance = this;
    }

    public void SetBackgroundActive(bool value)
    {
        if (value)
        {
            background.color = new Color(1f, 1f, 1f, 150f / 255f);
            hover = true;
        }
        else
        {
            background.color = new Color(1f, 1f, 1f, 50f / 255f);
            hover = false;
        }
    }

    public void OnClick()
    {
        if (hover)
        {
            GameController.instance.ZeroizeGrid();
        }
    }

    void Update()
    {

    }
}
