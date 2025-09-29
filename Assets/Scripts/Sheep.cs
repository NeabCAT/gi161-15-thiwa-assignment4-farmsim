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

    public void InitSheep(string name)
    {
        base.Init(name, 50, 50);
        PreferedFood = FoodType.Clover;
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

    public override string Produce()
    {
        int totalWool = 0;

        if (Happiness >= 55)
        {
            totalWool = Happiness / 25;
            Wools += totalWool;
            Debug.Log($"{Name} produced {totalWool} pieces of wool, Total Wools: {Wools} pieces");
            return $"{totalWool} pieces of wool";
        }
        else 
        {
            Wools += totalWool;
            Debug.Log($"{Name} produced {totalWool} pieces of wool, Total Wools: {Wools} pieces");

            return $"no pieces of wool";
        }


    }
}
