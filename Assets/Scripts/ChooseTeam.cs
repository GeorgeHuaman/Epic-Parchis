using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

public class ChooseTeam : SpatialNetworkBehaviour, IVariablesChanged
{
    public NetworkVariable<int> teamID = new NetworkVariable<int>();
    public void TagTeam(int x)
    {
        teamID.value = x;
    }

    public void Confirm()
    {

    }

    public void OnVariablesChanged(NetworkObjectVariablesChangedEventArgs args)
    {
        throw new System.NotImplementedException();
    }
}
