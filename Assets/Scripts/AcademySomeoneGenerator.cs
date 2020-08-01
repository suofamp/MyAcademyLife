using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcademySomeoneGenerator : MonoBehaviour
{
    public GameObject someonePrefab;
    public Destinations destinations;
    public int roadWidth;
    public int direction;
    public int start;
    public int building;
    private Vector2 position;
    private int generateSwitch;
    private List<(float, float)> generatePosition = new List<(float, float)>();
    private AcademySomeoneMovingController academySomeoneMovingController;
    private int goal;

    private int testCnt;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        for (int i = 0; i < roadWidth; i++)
        {
            if (direction == 0)
            {
                generatePosition.Add((position.x + i, position.y));
            }
            else if (direction == 2)
            {
                generatePosition.Add((position.x, position.y + i));
            }
        }
        //Generating();
        testCnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(testCnt == 0)
        {
            Generating();
        }
        testCnt++;
    }

    private void Generating()
    {
        int br = Random.Range(0, destinations.buildings.Count);//建物を決定
        while(br == building)
        {
            br = Random.Range(0, destinations.buildings.Count);
        }
        int goal = destinations.buildings[br][Random.Range(0, destinations.buildings[br].Count)];//出入り口を決定
        //Debug.Log(goal);
        Queue<int> bfs = new Queue<int>();
        int[] dist = new int[28];
        for (int i = 0; i < dist.Length; i++)
        {
            dist[i] = -1;
        }
        bfs.Enqueue(start);
        dist[start] = 0;
        //Debug.Log(bfs.Count);
        while (bfs.Count != 0)
        {
            int currentPoint = bfs.Dequeue();
            //Debug.Log(currentPoint);
            for (int i = 0; i < destinations.connections[currentPoint].Count; i++)
            {
                int nextPoint = destinations.connections[currentPoint][i];
                //Debug.Log(nextPoint);
                if (nextPoint == goal)
                {
                    dist[nextPoint] = dist[currentPoint] + 1;
                    break;
                }
                if (dist[nextPoint] == -1)
                {
                    //Debug.Log(nextPoint);
                    bfs.Enqueue(nextPoint);
                    dist[nextPoint] = dist[currentPoint] + 1;
                }
            }
            if (dist[goal] != -1)
            {
                break;
            }
        }
        List<int> route = new List<int>();
        route.Add(goal);
        int beforePoint = goal;
        int n;
        int rand;
        for (int i = 0; i < dist[goal] - 1; i++)
        {
            //Debug.Log(beforePoint);
            n = destinations.connections[beforePoint].Count;
            for (int j = 0; j < n; j++)
            {
                rand = Random.Range(0, destinations.connections[beforePoint].Count);
                if (dist[destinations.connections[beforePoint][rand]] == dist[beforePoint] - 1)
                {
                    beforePoint = destinations.connections[beforePoint][rand];
                    route.Add(beforePoint);
                    break;
                }
                destinations.connections[beforePoint].RemoveAt(rand);
            }
        }
        route.Reverse();
        for (int i = 0; i < route.Count; i++)
        {
            //Debug.Log(route[i]);
        }

        int r = Random.Range(0, roadWidth);
        GameObject tmpSomeone = Instantiate(someonePrefab,new Vector2(generatePosition[r].Item1,generatePosition[r].Item2), Quaternion.identity) as GameObject;
        academySomeoneMovingController = tmpSomeone.GetComponent<AcademySomeoneMovingController>();
        for (int i = 0; i < route.Count; i++)
        {
            int dr = Random.Range(0, destinations.wayPoints[route[i]].Count);
            academySomeoneMovingController.wayPoints.Add(destinations.wayPoints[route[i]][dr]);
        }

        /*
        List<(float, float)> generating = generatePosition;
        System.Random rng = new System.Random();
        int n = generating.Count;
        int settingDirection = 0;
        System.Random rnd = new System.Random();    // インスタンスを生成
        int rand = rnd.Next(2);
        
        int ranm = Random.Range(0, generateCount.Count);
        //Debug.Log(ranm);
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
        for (int i = 0; i < generateCount[ranm]; i++)
        {
            GameObject tmpSomeone = Instantiate(someonePrefab, new Vector2(generating[i].Item1, generating[i].Item2), Quaternion.identity) as GameObject;
            someoneMovingController = tmpSomeone.GetComponent<SomeoneMovingController>();
            someoneMovingController.direction = settingDirection;
        }
        */
    }
}
