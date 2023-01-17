using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIActionListener : MonoBehaviour
{

    /// <summary>
    /// TO:DO 
    /// Animasyonlarý kontrol etmedik. Ödev olarak animasyonlar için de gerekli olan methodlarý da listener içinde oluþturmanýz ve 
    /// doðru yerde çaðýrmanýzý bekliyorum :)
    /// </summary>

    [SerializeField] private GameObject claimPanel;
    [SerializeField] private GameObject successPanel;


    private void OnEnable()
    {
        EventManager.OnClaimOpenBtnClick += OnClaimPanelOpen;
        EventManager.OnClaimPanelCloseBtnClick += OnClaimPanelClose;
        EventManager.OnSuccessPanelOpenBtnClick += OnSuccessPanelOpen;
        EventManager.OnSuccessPanelCloseBtnClick += OnSuccessPanelClose;
    }

    private void OnSuccessPanelClose()
    {
        successPanel.SetActive(false);
    }

    private void OnSuccessPanelOpen()
    {
        successPanel.SetActive(true);
    }

    private void OnClaimPanelClose()
    {
        claimPanel.SetActive(false);
    }

    private void OnClaimPanelOpen()
    {
        claimPanel.SetActive(true);
    }
}
