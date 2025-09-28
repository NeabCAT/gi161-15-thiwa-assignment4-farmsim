using UnityEngine;

public class Sheep : Animals
{
    private int wools;
    public int Wools //Property
    {
        get { return wools; }
        private set
        {
            if (value < 0) wools = 0;
            else wools = value;
        }
    }

    public override void Init(string newName, int newHunger, int newhappiness)
    {
        base.Init(newName, newHunger, newhappiness);
        Wools = 0;
    }


    public override void MakeSound()
    {
        Debug.Log($"{Name} say Baeee!!");
    }


    public override void GetStatus()
    {
        base.GetStatus();
    }

}
