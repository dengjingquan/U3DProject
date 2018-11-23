﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckNameGoBtnController : MonoBehaviour {
    public Text UserNameValueText;
    public InputField InputUserName;
    public Text BadNameText;
    public GameObject InputNameBg;
    public GameObject Player;
   


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        string UserName = InputUserName.text.ToString();
        //目前名字合法性只做长度和包含空格检测... 
        if (UserName.Length < 1 || UserName.Length > 8 || UserName.Contains(" "))
        {
            //长度不符提示
            BadNameText.gameObject.SetActive(true);
            return;
        }
        //设置用户名文本
        UserNameValueText.text = UserName;
        //关闭输入用户名背景
        InputNameBg.SetActive(false);
        //激活小球
        Player.gameObject.SetActive(true);
    }
}
