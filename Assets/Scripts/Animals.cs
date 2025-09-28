using UnityEngine;

public abstract class Animals : MonoBehaviour
{
    private string name;
    public string Name //Property
    {
        get => name;
        private set => name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    private int hunger;
    public int Hunger //Property
    {
        get { return hunger; }
        private set
        {
            if (value > 50) hunger = 50;
            else if (value < 0) hunger = 0;
            else hunger = value;
        }
    }

    private int happiness;
    public int Happiness //Property
    {
        get { return happiness; }
        private set
        {
            if (value > 50) happiness = 50;
            else if (value < 0) happiness = 0;
            else happiness = value;
        }
    }

    public virtual void Init(string newName, int newHunger, int newhappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newhappiness;
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int valueHappy)
    {
        Happiness += valueHappy;
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{Name} say  ");
    }

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness(amount * 2);
        Debug.Log($"{Name} was feed {amount} units of food. ");

    }
    public void Feed(string food , int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness(amount * 2);
        Debug.Log($"{Name} was feed {amount} of {food}. ");

    }

    public virtual void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger : {Hunger} | Happiness : {Happiness} ");
    }

    public void Sleep()
    {
        AdjustHunger(2);
        AdjustHappiness(10);
        Debug.Log($"{Name} slept and feels a little hungry, but very happy! ");

    }
}
