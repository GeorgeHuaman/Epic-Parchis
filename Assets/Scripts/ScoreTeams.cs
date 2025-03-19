using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SpatialSys.UnitySDK;
public class ScoreTeams : SpatialNetworkBehaviour, IVariablesChanged
{
    public TextMeshProUGUI hero;
    public TextMeshProUGUI rosa;
    public TextMeshProUGUI ballena;
    public TextMeshProUGUI skater;

    private NetworkVariable<int> scoreHero = new(initialValue: 0);
    private NetworkVariable<int> scoreRosa = new(initialValue: 0);
    private NetworkVariable<int> scoreBallena = new(initialValue: 0);
    private NetworkVariable<int> scoreSkater = new(initialValue: 0);

    public void RestHero()
    {
        GiveControl();
        if (scoreHero > 0)
        {
            scoreHero.value--;
            hero.text = scoreHero.value.ToString();
        }
    }
    public void SumHero()
    {
        GiveControl();
        scoreHero.value++;
    }
    public void RestRosa()
    {
        GiveControl();
        if (scoreRosa > 0)
        {
            scoreRosa.value--;
            rosa.text = scoreRosa.value.ToString();
        }
    }
    public void SumRosa()
    {
        GiveControl();
        scoreRosa.value++;
    }
    public void RestBallena()
    {
        GiveControl();
        if (scoreBallena > 0)
        {
            scoreBallena.value--;
            ballena.text = scoreBallena.value.ToString();
        }
    }
    public void SumBallena()
    {
        GiveControl();
        scoreBallena.value++;
    }
    public void RestSkater()
    {
        GiveControl();
        if (scoreSkater > 0)
        {
            scoreSkater.value--;
            skater.text = scoreSkater.value.ToString();
        }
    }
    public void SumSKater()
    {
        GiveControl();
        scoreSkater.value++;
    }

    public void GiveControl()
    {
        if (!hasControl)
        {
            SpatialNetworkObject obj = GetComponent<SpatialNetworkObject>();
            obj.RequestOwnership();
        }

    }
    public void OnVariablesChanged(NetworkObjectVariablesChangedEventArgs args)
    {
        if (args.changedVariables.ContainsKey(scoreHero.id))
        {
            hero.text = scoreHero.value.ToString();
        }
        if (args.changedVariables.ContainsKey(scoreRosa.id))
        {
            rosa.text = scoreRosa.value.ToString();
        }
        if (args.changedVariables.ContainsKey(scoreBallena.id))
        {
            ballena.text = scoreBallena.value.ToString();
        }
        if (args.changedVariables.ContainsKey(scoreSkater.id))
        {
            skater.text = scoreSkater.value.ToString();
        }
    }
}
