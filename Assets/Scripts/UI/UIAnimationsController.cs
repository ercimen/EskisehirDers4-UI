using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimationsController : MonoBehaviour
{
    [SerializeField] private Animator claimPanelAnimator;
    [SerializeField] private Animator successPanelAnimator;


    public void PlayOpenAnimationSuccessPanel()
    {
        successPanelAnimator.Play("Panel_Open");
    }

    public void PlayCloseAnimationSuccessPanel()
    {
        successPanelAnimator.Play("Close_Panel");
    }

    public void SetAnimationSpeedClaimPanel(float value)
    {
        claimPanelAnimator.speed = value;
    }
}
