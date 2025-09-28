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
        chicken.Init("Torchic", 15,5);
        FarmAnimals.Add(chicken);
        cow.Init("Milktank",20,10);
        FarmAnimals.Add(cow);
        sheep.Init("Mareep", 15,10);
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
            animalsSoundFeed.Feed(3);

            //check status hunger
            animalsSoundFeed.GetStatus();

        }

        Debug.Log("");
        //Chicken Feed(String,int) 
        chicken.Feed("corn",3);
        chicken.GetStatus();
        chicken.Sleep();
        chicken.GetStatus();

        Debug.Log("");
        //Cow Feed(String,int)
        cow.Feed("Hay", 5);
        cow.GetStatus();
        cow.Moo();

        Debug.Log("");
        //Sheep Feed(String,int)
        sheep.Feed("grass", 7);
        sheep.GetStatus();

    }

}
