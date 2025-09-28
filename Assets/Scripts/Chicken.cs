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

    public override void Init(string newName, int newHunger, int newhappiness)
    {
        base.Init(newName, newHunger, newhappiness);
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

}