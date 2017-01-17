﻿using UnityEngine;
using System.Collections;
using System;

public class SceneBase : UIBase, IEventListener {

    public virtual void OnInit()
    {
        WebLogic.Instance.AddEventListener(1, this);
        Init();
    }

}

public enum SceneState
{
    /// <summary>
    /// 登陆界面
    /// </summary>
    SceneLogin,

    /// <summary>
    /// 房间界面
    /// </summary>
    SceneRoom,

    /// <summary>
    /// 房间里界面
    /// </summary>
    SceneInRoom,

    /// <summary>
    /// 游戏界面
    /// </summary>
    SceneGame,
}
