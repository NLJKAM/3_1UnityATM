using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }

    public int cash;
    public int balance;
    public Text cashTxt;
    public Text balanceTxt;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // 중복 인스턴스가 생성될 경우 제거
        }
    }
    void Update()
    {
        TxtView();
    }
    private void TxtView()
    {
        cashTxt.text = cash.ToString();
        balanceTxt.text = "Balance : " + balance.ToString();
    }
}
