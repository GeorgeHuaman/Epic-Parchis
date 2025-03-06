using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : SpatialNetworkBehaviour
{
    private const int DICE_FACES = 6;

    [Header("Dice Animation")]
    [SerializeField] private Quaternion startingRotation;
    [SerializeField] private Vector3 diceRotationShift;
    [SerializeField] private float animationDuration;
    [SerializeField] private float animationTimer;
    [SerializeField] private bool isRolling;

    [Header("Dice Positions")]
    [SerializeField] private Vector3[] orientations;

    private void Start()
    {
        startingRotation = transform.rotation;
    }

    private void Update()
    {
        if(animationTimer > 0) 
            animationTimer -= Time.deltaTime;

        else if (isRolling)
            EndRoll();

        if (isRolling)
            RollAnimation();
    }

    public void Roll()
    {
        if (isRolling) return;

        GiveControl();
        isRolling = true;
        animationTimer = animationDuration;
    }

    private void EndRoll()
    {
        isRolling = false;

        int value = Random.Range(1, DICE_FACES + 1);
        //SpatialBridge.coreGUIService.DisplayToastMessage(value.ToString());

        if (orientations.Length > value - 1)
            transform.rotation = Quaternion.Euler(orientations[value - 1]);
        else 
            transform.rotation = startingRotation;
    }

    private void RollAnimation()
    {
        transform.rotation *= Quaternion.Euler(diceRotationShift * Time.deltaTime);
    }
    public void GiveControl()
    {
        if (!hasControl)
        {
            SpatialNetworkObject obj = GetComponent<SpatialNetworkObject>();
            obj.RequestOwnership();
        }

    }
}
