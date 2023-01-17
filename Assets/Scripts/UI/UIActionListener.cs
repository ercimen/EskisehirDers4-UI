using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIActionListener : MonoBehaviour
{

    /// <summary>
    /// TO:DO 
    /// Animasyonlar� kontrol etmedik. �dev olarak animasyonlar i�in de gerekli olan methodlar� da listener i�inde olu�turman�z ve 
    /// do�ru yerde �a��rman�z� bekliyorum :)
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
