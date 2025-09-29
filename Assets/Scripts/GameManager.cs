using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chicken chicken;
    public Cow cow;
    public Sheep sheep;
    public List<Animals> FarmAnimals;

    private void Start()
    {
        chicken.InitChicken("Torchic");
        FarmAnimals.Add(chicken);
        cow.InitCow("Milktank");
        FarmAnimals.Add(cow);
        sheep.InitSheep("Mareep");
        FarmAnimals.Add(sheep);

        Debug.Log("*** Welcome to happy Farm Sim  ***");
        Debug.Log($"= There are {FarmAnimals.Count} animals living in the Happy Farm =");


        foreach (var animal in FarmAnimals)
        {
            animal.GetStatus();
        }

        //Sound && Feed(int)
        foreach (var animalsSoundFeed in FarmAnimals)
        {
            animalsSoundFeed.MakeSound();
            animalsSoundFeed.Feed(5);

        }
        

        //Cow
        //Feed Type 1
        cow.Feed(10);

        //Feed Type 2
        cow.Feed(FoodType.Hay,20);
        cow.Produce();

        //Loop method
        for (int i = 0; i < 2; i++)
        {
            cow.Feed(FoodType.Hay, 30);
            cow.Produce();
        }


        //Chicken
        //Feed Type 1
        chicken.Feed(10);

        //Feed Type 2
        chicken.Feed(FoodType.Grain, 20);
        chicken.Produce();

        for (int i = 0; i < 2; i++)
        {
            chicken.Feed(FoodType.RottenFood, 30);
            chicken.Produce();
        }

        //Sheep
        //FoodType.AnimalFood
        sheep.Feed(FoodType.AnimalFood,20);

        //Feed Type 2
        sheep.Feed(FoodType.Clover, 45);
        sheep.Produce();

        for (int i = 0; i < 4; i++)
        {
            sheep.Feed(FoodType.RottenFood, 10);
            sheep.Produce();
        }



        /*Debug.Log("");
        //Chicken Feed(String,int) 
        chicken.Feed(FoodType.Grain,3);
        chicken.GetStatus();
        chicken.Sleep();
        chicken.GetStatus();

        Debug.Log("");
        //Cow Feed(String,int)
        cow.Feed(FoodType.Hay, 10);
        cow.GetStatus();
        cow.Moo();

        Debug.Log("");
        //Sheep Feed(String,int)
        sheep.Feed(FoodType.Clover, 7);
        sheep.GetStatus();

        cow.Produce();

        chicken.Feed(FoodType.Grain,30);
        chicken.Produce();
        chicken.Feed(FoodType.Grain, 10);
        chicken.Produce();
        chicken.Feed(FoodType.RottenFood, 10);
        chicken.Produce();*/


    }

}
