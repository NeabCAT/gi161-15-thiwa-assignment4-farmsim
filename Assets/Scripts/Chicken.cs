using UnityEngine;

public class Chicken : Animals
{
   
    private int eggs;
    public int Eggs //Property
    {
        get { return eggs; }
        private set { if (value < 0) eggs = 0;
            else eggs = value;
            }
    }

    public void InitChicken(string name)
    {
        base.Init(name, 50, 50);
        PreferedFood = FoodType.Grain;
        Eggs = 0;
    }


    public override void MakeSound()
    {
        Debug.Log($"{Name} say Clucks!!");
    }


    public override void GetStatus()
    {
        base.GetStatus();
    }

    public override string Produce()
    {
        int currentEggs = 0;

        if (Happiness <= 50)
        {
            Debug.Log($"{Name} produced  {currentEggs} eggs, Total Eggs: {Eggs} eggs");
            return "No eggs";
        }
        else if (Happiness >= 51 && Happiness <= 79 )
        {
            currentEggs = 2;
            Eggs += currentEggs;
            Debug.Log($"{Name} produced  {currentEggs} eggs, Total Eggs: {Eggs} eggs");
            return $"{Eggs} eggs";
        }
        else
        {
            currentEggs = 3;
            Eggs += currentEggs;
            Debug.Log($"{Name} produced {currentEggs} eggs, Total Eggs: {Eggs} eggs");
            return $"{Eggs} eggs";

        }
    }

}