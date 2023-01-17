using System;
using UnityEngine;


public class EventManager : MonoBehaviour
{
    public static Action OnClaimOpenBtnClick;
    public static Action OnSuccessPanelOpenBtnClick;
    public static Action OnClaimPanelCloseBtnClick;
    public static Action OnSuccessPanelCloseBtnClick;


    public void OnClaimOpenBtn_Click()
    {
        OnClaimOpenBtnClick.Invoke();
    }

    public void OnSuccessPanelOpenBtn_Click()
    {
        OnSuccessPanelOpenBtnClick.Invoke();
    }

    public void OnClaimPanelCloseBtn_Click()
    {
        OnClaimPanelCloseBtnClick.Invoke();
    }

    public void OnSuccessPanelCloseBtn_Click()
    {
        OnSuccessPanelCloseBtnClick.Invoke();
    }

}
