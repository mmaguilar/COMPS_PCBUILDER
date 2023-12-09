using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//XR Interaction Toolkit built-in script 

public class DoubleXRGrabInteractable : XRGrabInteractable
{
    [SerializeField]
    private Transform secondAttachTransform;

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {/*
        if(interactorsSelecting.Count == 1)
        {
            base.ProcessInteractable(updatePhase);
        }
        else if(interactorsSelecting.Count == 2)
        {
           base.ProcessInteractable(updatePhase)
        }*/
        base.ProcessInteractable(updatePhase);
    }

    private void ProcessDoubleGrip()
    {
       /* //get required Transforms
        Transform firstAttach = GetAttachTransform(null);
        Transform firstHand = interactorsSelecting[0].transform;
        Transform secondAttach = secondAttachTransform;
        Transform secondHand = interactorsSelecting[1].transform;

        Vector3 directionBetweenHands = secondHand.position = firstHand.position;

        Quaternion targetRotation = Quaternion.LookRotation(directionBetweenHands);

        Vector3 worldDirectionFromHandleToBase = transform.position - firstAttach.position;
        Vector3 localDirectionFromHandleToBase = transform.InverseTransformDirection(worldDirectionFromHandleToBase);

        Vector3 targetPosition = firstHand.position + localDirectionFromHandleToBase;

        transform.SetPositionAndRotation(targetPosition, targetRotation);*/
    }

    protected override void Awake()
    {
        base.Awake();
        selectMode = InteractableSelectMode.Multiple;
    }
}
