﻿using UnityEngine;
using System.Collections;

public interface IState
{
    StateMgr mgr
    {
        get;
    }
    void OnInit();

    void OnExit();

    void OnUpdate();

    void ClickEvent(int tag);
}