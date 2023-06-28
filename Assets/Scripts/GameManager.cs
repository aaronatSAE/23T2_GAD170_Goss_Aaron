using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // We want to store a reference to each car in our game.
    [SerializeField] private Car[] allRacecarsArray;
    [SerializeField] private List<Car> allRacecarsList = new List<Car>();

    private void Start()
    {
        // We want to output the names of all our cars at Start

        // For our ARRAY:
        Debug.Log(allRacecarsArray.Length);
        Debug.Log(allRacecarsArray[3].name);

        // And for our LIST:
        Debug.Log(allRacecarsList.Count);
        Debug.Log(allRacecarsList[3].name);

        CheckWhichCarIsCrashed();
    }

    private void CheckWhichCarIsCrashed()
    {
        // use a FOR LOOP
        for (int selectedCarIndex = 0; selectedCarIndex < allRacecarsArray.Length; selectedCarIndex++)
        {
            if (allRacecarsList[selectedCarIndex].isCrashed == true)
            {
                Debug.Log("CRASHED " + selectedCarIndex);
                Debug.Log("A car has crashed: [" + allRacecarsList[selectedCarIndex].name + "]!");
            }
            if (allRacecarsList[selectedCarIndex].speedLimit > 100)
            {
                // DO A THING
            }
        }

        //if (allRacecarsList[0].isCrashed == true)
        //{
        //    Debug.Log("CRASHED 0");
        //}
        //if (allRacecarsList[1].isCrashed == true)
        //{
        //    Debug.Log("CRASHED 1");
        //}
        //if (allRacecarsList[2].isCrashed == true)
        //{
        //    Debug.Log("CRASHED 2");
        //}
        //if (allRacecarsList[3].isCrashed == true)
        //{
        //    Debug.Log("CRASHED 3");
        //}
    }

    public void HelloWorldButton()
    {
        Debug.Log("Hello World from a UI button!");
    }
}
