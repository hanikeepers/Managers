using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager 
{
    public Action KeyAction = null; // 델리게이트 이용 이벤트를 사용하기 위해




    public void OnUpdate()
    {
        if(Input.anyKey == false)
        return;
        if(KeyAction !=null)
        KeyAction.Invoke();
        //KeyAction은 델리게이트 혹은 이벤트 타입을 나타내는 변수 
        //Invoke는 해당 델리게이트나 이벤트에 등록된 메서드를 실행하는 메서드입니다.
        
    }
}
