﻿using UnityEngine;
using System.Collections;

//This is a basic interface with a single required
//method.
public interface ISelectable
{
    void OnHoverOver();
    void OnHoverOut();
    void OnSelect();
    void OnUnSelect();
}