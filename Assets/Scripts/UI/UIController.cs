using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject claimPanel;
    [SerializeField] private GameObject successPanel;

    public void SetActiveClaimPAnel(bool value)
    {
        claimPanel.SetActive(value);
    }

    public void SetActiveSuccessPanel(bool value)
    {
        successPanel.SetActive(value);
    }

}
