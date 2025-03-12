using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreTeams : MonoBehaviour
{
    public TextMeshProUGUI hero;
    public TextMeshProUGUI rosa;
    public TextMeshProUGUI ballena;
    public TextMeshProUGUI skater;
    
    public void RestHero()
    {
        int i = int.Parse(hero.text);
        i = i - 1;
        hero.text = i.ToString();
    }
    public void SumHero()
    {
        int i = int.Parse(hero.text);
        i = i + 1;
        hero.text = i.ToString();
    }
    public void RestRosa()
    {
        int i = int.Parse(rosa.text);
        i = i - 1;
        rosa.text = i.ToString();
    }
    public void SumRosa()
    {
        int i = int.Parse(rosa.text);
        i = i + 1;
        rosa.text = i.ToString();
    }
    public void RestBallena()
    {
        int i = int.Parse(ballena.text);
        i = i - 1;
        ballena.text = i.ToString();
    }
    public void SumBallena()
    {
        int i = int.Parse(ballena.text);
        i = i + 1;
        ballena.text = i.ToString();
    }
    public void RestSkater()
    {
        int i = int.Parse(skater.text);
        i = i - 1;
        skater.text = i.ToString();
    }
    public void SumSKater()
    {
        int i = int.Parse(skater.text);
        i = i + 1;
        skater.text = i.ToString();
    }
}
