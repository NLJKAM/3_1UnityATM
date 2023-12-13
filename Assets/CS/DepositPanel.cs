using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositPanel : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject nobalancePanel;

    public InputField inputField;
    void Update()
    {
        if (inputField.text.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            InputCount();
        }
    }
    public void BacktoMain()
    {
        mainPanel.SetActive(true);
        gameObject.SetActive(false);
    }
    public void DepositButton(int count)
    {
        if(count <= UIController.Instance.cash)
        {
            UIController.Instance.cash -= count;
            UIController.Instance.balance += count;
        }
        else
        {
            NobalancePanel();
        }
    }
    public void NobalancePanel()
    {
        nobalancePanel.SetActive(true);
    }
    public void InputCount()
    {
        int count = int.Parse(inputField.text);
        if (count <= UIController.Instance.cash)
        {
            UIController.Instance.cash -= count;
            UIController.Instance.balance += count;
        }
        else
        {
            NobalancePanel();
        }
    }
}
