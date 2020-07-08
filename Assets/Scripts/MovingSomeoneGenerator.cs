﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSomeoneGenerator : MonoBehaviour
{
    public int roadWidth;
    public int direction;
    //public int maxGenerateCounts;
    public int generateProbability;
    public GameObject someonePrefab;
    public List<int> maxGenerateProbability = new List<int>();
    //public MovingSomeoneGenerator movingSomeoneGenerator;
    private List<(float, float)> generatePosition = new List<(float, float)>();
    private List<int> generateCount = new List<int>();
    private Vector2 position;
    //private int[] someoneCounts;
    private int generateSwitch;
    SomeoneMovingController someoneMovingController;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        for(int i = 0;i < roadWidth; i++)
        {
            if(direction == 0)
            {
                generatePosition.Add((position.x + i, position.y));
            }
            else if(direction == 2)
            {
                generatePosition.Add((position.x, position.y + i));
            }
        }

        for(int i = 1;i <= maxGenerateProbability.Count; i++)
        {
            for(int j = 0;j < maxGenerateProbability[i - 1]; j++)
            {
                generateCount.Add(i);
            }
        }
        Debug.Log(generateCount.Count);
        /*
        for(int i = 0;i < generatePosition.Count; i++)
        {
            Debug.Log(generatePosition[i]);
        }
        */
        //someoneCounts = new int[maxGenerateCounts];
        generateSwitch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(1, 1000) <= generateProbability)
        {
            generateSwitch++;
        }
        if (generateSwitch > 10)
        {
            //Debug.Log("spown");
            Generating();
            generateSwitch = 0;
        }
    }

    private void Generating()
    {
        List<(float, float)> generating = generatePosition;
        System.Random rng = new System.Random();
        int n = generating.Count;
        int settingDirection = 0;
        System.Random rnd = new System.Random();    // インスタンスを生成
        int rand = rnd.Next(2);
        int ranm = Random.Range(1, generateCount.Count);
        Debug.Log(ranm);
        if (direction == 0)
        {
            settingDirection = rand * 4;
        }
        else if (direction == 2)
        {
            settingDirection = 2 + (rand * 4);
        }

        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (float, float) tmp = generating[k];
            generating[k] = generating[n];
            generating[n] = tmp;
        }
        for(int i = 0;i < generateCount[ranm]; i++)
        {
            GameObject tmpSomeone = Instantiate(someonePrefab, new Vector2(generating[i].Item1, generating[i].Item2), Quaternion.identity) as GameObject;
            someoneMovingController = tmpSomeone.GetComponent<SomeoneMovingController>();
            someoneMovingController.direction = settingDirection;
        }
    }
}