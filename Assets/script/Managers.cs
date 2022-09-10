using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_Instance;

    public static Managers Instance { get { Init(); return s_Instance; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
    }

    static void Init()
    {
        if (null == s_Instance)
        {
            GameObject gameObject = GameObject.Find("@Managers");
            if (null == gameObject)
            {
                gameObject = new GameObject { name = "@Managers" }; //gameObject 생성
                gameObject.AddComponent<Managers>();                //gmaeObject에 컴포넌트 붙이기.
            }

            DontDestroyOnLoad(gameObject);                          //삭제되지 않게 바뀐다.
            s_Instance = gameObject.GetComponent<Managers>();
        }
    }
}