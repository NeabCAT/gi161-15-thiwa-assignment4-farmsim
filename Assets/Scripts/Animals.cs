using UnityEngine;
public enum FoodType
{
    Hay,
    Grain,
    Clover,
    RottenFood,
    AnimalFood
}


public abstract class Animals : MonoBehaviour
{
    private string name;
    public string Name //Property
    {
        get => name;
        private set => name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    /*private int hunger;
    public int Hunger //Property
    {
        get { return hunger; }
        private set
        {
            if (value > 50) hunger = 50;
            else if (value < 0) hunger = 0;
            else hunger = value;
        }
    }*/


    protected int maxHunger = 100;
    public int Hunger { get; protected set; }



    protected int maxHappiness = 100;
    public int Happiness { get; protected set; }

    /*public int Happiness //Property
    {
        get { return happiness; }
        private set
        {
            if (value > 50) happiness = 50;
            else if (value < 0) happiness = 0;
            else happiness = value;
        }
    }*/

    public FoodType PreferedFood { get; protected set; }


    public virtual void Init(string newName, int newHunger, int newhappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newhappiness;
    }

    public void AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, 0, maxHunger);
        //Hunger *= amount;
    }

    public void AdjustHappiness(int valueHappy)
    {
        Happiness = Mathf.Clamp(Happiness + valueHappy, 0, maxHappiness);
        
        //Happiness += valueHappy;

    }

    /*public virtual void MakeSound()
    {
        Debug.Log($"{Name} say  ");
    }*/

    public abstract void MakeSound();

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness(amount/2);
        Debug.Log($"{Name} was fed {amount} units of generic food. Current Happiness: {Happiness} ");

    }
    public void Feed(FoodType food , int amount)
    {
        if (food == FoodType.RottenFood)
        {
            int decreasedFood = 20;
            AdjustHappiness(-decreasedFood);
            Debug.Log($"{Name} was fed with rotten food  : {food}, Unhappy! Happiness decreased {decreasedFood} units,  Current Happiness: {Happiness} ");
            return;
        }

        else if (food == FoodType.AnimalFood)
        {
            Feed(amount);
            Debug.Log($"{Name} was fed with Animal food  : {food}, It's Ok! , Current Happiness: {Happiness} ");
        }

        if (food == PreferedFood) 
        {
            int increasedFood = 15;
            AdjustHappiness(+increasedFood);
            AdjustHunger(-amount);
            Debug.Log($"{Name} was fed {amount} units of preferred food : {food}, Happiness Increased {increasedFood} units,  Current Happiness: {Happiness} ");
            return;
        }

        /*AdjustHunger(-amount);
        AdjustHappiness(amount * 2);
        Debug.Log($"{Name} was feed {amount} of {food}. ");*/

    }

    public virtual void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger : {Hunger} | Happiness : {Happiness} | Prefered Food : {PreferedFood} ");
    }

    public void Sleep()
    {
        AdjustHunger(2);
        AdjustHappiness(10);
        Debug.Log($"{Name} slept and feels a little hungry, but very happy! ");

    }

    public abstract string Produce();
}
