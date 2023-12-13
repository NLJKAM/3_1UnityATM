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
            Destroy(gameObject); // �ߺ� �ν��Ͻ��� ������ ��� ����
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
