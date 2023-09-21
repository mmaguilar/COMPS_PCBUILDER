using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateXRGrabInteractable : XRGrabInteractable
{

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
    }
}
