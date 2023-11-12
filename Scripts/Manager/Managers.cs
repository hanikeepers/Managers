using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // static 으로 인해 유일성이 보장된다.
    static Managers Instance
    {
        get { Init(); return s_instance; } // 유일한 매니저를 갖고 온다.
    }

    InputManager _input = new InputManager(); 
    public static InputManager Input //InputManager을 사용하기 위해 Manager.Input을 이용해서 불러온다
    {
        get { return Instance._input; }
    }

    void Start()
    {
        Init();
    }


    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject gameObject = GameObject.Find("@Manager");
            if (gameObject == null)
            {
                gameObject = new GameObject { name = "@Manager" };
                gameObject.AddComponent<Managers>();
            }

            DontDestroyOnLoad(gameObject);
            s_instance = gameObject.GetComponent<Managers>();

        }


    }
}
