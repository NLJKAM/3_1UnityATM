using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : MonoBehaviour
{
    public GameObject depositPanel;
    public GameObject withdrawPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDepositPanel()
    {
        depositPanel.SetActive(true);
        gameObject.SetActive(false);
    }
    public void OnWithdrawPanel()
    {
        withdrawPanel.SetActive(true);
        gameObject.SetActive(false);   
    }
}
