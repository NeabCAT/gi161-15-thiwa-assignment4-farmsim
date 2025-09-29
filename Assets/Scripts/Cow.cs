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

    public void InitCow(string name)
    {
        base.Init(name, 50, 50);
        PreferedFood = FoodType.Hay;
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

    public override string Produce()
    {
        float totalMilk = 0f;

        if (Happiness > 70)
        {
            totalMilk = (float)Happiness / 10;
            Milk += totalMilk;
            Debug.Log($"{Name} produced {totalMilk} units of milk, Total Milk: {Milk} units");
            return $"{Name} produced {totalMilk} units of milk, Total Milk: {Milk} units";
        }
        else 
        {
            Debug.Log($"{Name} produced {totalMilk} units of milk, Total Milk: {Milk} units");
            Milk += totalMilk;
            return "Cow is not happy enough to produce milk";
        }
    }
}