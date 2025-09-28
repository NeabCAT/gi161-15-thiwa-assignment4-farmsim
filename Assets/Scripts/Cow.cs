using UnityEngine;
public class Cow : Animals
{
    private float milk;
    public float Milk //Property
    {
        get { return milk; }
        private set
        {
            if (value < 0) milk = 0;
            else milk = value;
        }
    }

    public override void Init(string newName, int newHunger, int newhappiness)
    {
        base.Init(newName, newHunger, newhappiness);
        Milk = 0f;

    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Moo!! ");
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }

    public void Moo()
    {
        AdjustHappiness(15);
        Debug.Log($"{Name} gives a lound MooMooMoo!! | Current Happiness : {Happiness} ");
    }

}