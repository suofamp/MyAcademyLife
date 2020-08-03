using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destinations : MonoBehaviour
{
    public List<List<(float, float)>> wayPoints = new List<List<(float, float)>>();//各中継点 中継点→座標
    public List<List<int>> connections = new List<List<int>>();//各点の繋がり 各中継点→つながっている中継点
    public List<List<List<(float, float)>>> destinations = new List<List<List<(float, float)>>>();//各目的地 建物→ドア→座標
    public List<List<int>> buildings = new List<List<int>>();//各建物のドア 各建物→各ドア
    public List<int> destroy;//0:上, 1:右, 2:下, 3:左
    List<List<(float, float)>> buildingN = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingS = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingE = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingL = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingP = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingO = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingC = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingRw = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingRe = new List<List<(float, float)>>();
    List<List<(float, float)>> buildingRs = new List<List<(float, float)>>();
    List<(float, float)> destination00 = new List<(float, float)>();
    List<(float, float)> destination01 = new List<(float, float)>();
    List<(float, float)> destination02 = new List<(float, float)>();
    List<(float, float)> destination03 = new List<(float, float)>();
    List<(float, float)> destination04 = new List<(float, float)>();
    List<(float, float)> destination05 = new List<(float, float)>();
    List<(float, float)> destination06 = new List<(float, float)>();
    List<(float, float)> destination07 = new List<(float, float)>();
    List<(float, float)> destination08 = new List<(float, float)>();
    List<(float, float)> destination09 = new List<(float, float)>();
    List<(float, float)> destination10 = new List<(float, float)>();
    List<(float, float)> destination11 = new List<(float, float)>();
    List<(float, float)> destination12 = new List<(float, float)>();
    List<(float, float)> destination13 = new List<(float, float)>();
    List<(float, float)> destination14 = new List<(float, float)>();
    List<(float, float)> destination15 = new List<(float, float)>();
    List<(float, float)> destination16 = new List<(float, float)>();
    List<(float, float)> destination17 = new List<(float, float)>();
    List<(float, float)> destination18 = new List<(float, float)>();
    List<(float, float)> destination19 = new List<(float, float)>();
    List<(float, float)> wayPoint00 = new List<(float, float)>();
    List<(float, float)> wayPoint01 = new List<(float, float)>();
    List<(float, float)> wayPoint02 = new List<(float, float)>();
    List<(float, float)> wayPoint03 = new List<(float, float)>();
    List<(float, float)> wayPoint04 = new List<(float, float)>();
    List<(float, float)> wayPoint05 = new List<(float, float)>();
    List<(float, float)> wayPoint06 = new List<(float, float)>();
    List<(float, float)> wayPoint07 = new List<(float, float)>();
    List<int> connection00;
    List<int> connection01;
    List<int> connection02;
    List<int> connection03;
    List<int> connection04;
    List<int> connection05;
    List<int> connection06;
    List<int> connection07;
    List<int> connection08;
    List<int> connection09;
    List<int> connection10;
    List<int> connection11;
    List<int> connection12;
    List<int> connection13;
    List<int> connection14;
    List<int> connection15;
    List<int> connection16;
    List<int> connection17;
    List<int> connection18;
    List<int> connection19;
    List<int> connection20;
    List<int> connection21;
    List<int> connection22;
    List<int> connection23;
    List<int> connection24;
    List<int> connection25;
    List<int> connection26;
    List<int> connection27;
    List<int> doorN;
    List<int> doorS;
    List<int> doorE;
    List<int> doorL;
    List<int> doorP;
    List<int> doorO;
    List<int> doorC;
    List<int> doorRw;
    List<int> doorRe;
    List<int> doorRs;

    private void Start()
    {
        //buildings setup
        doorN = new List<int>() { 0, 1, 2 };
        doorS = new List<int>() { 3, 4, 5 };
        doorE = new List<int>() { 6, 7 };
        doorL = new List<int>() { 8, 9, 10 };
        doorP = new List<int>() { 11 };
        doorO = new List<int>() { 12 };
        doorC = new List<int>() { 13 };
        doorRw = new List<int>() { 14, 15 };
        doorRe = new List<int>() { 16, 17 };
        doorRs = new List<int>() { 18, 19 };

        buildings.Add(doorN);
        buildings.Add(doorS);
        buildings.Add(doorE);
        buildings.Add(doorL);
        buildings.Add(doorP);
        buildings.Add(doorO);
        buildings.Add(doorC);
        buildings.Add(doorRw);
        buildings.Add(doorRe);
        buildings.Add(doorRs);
        //Debug.Log(buildings.Count);

        //destroy points
        destroy.Add(0);//N
        destroy.Add(0);
        destroy.Add(0);
        destroy.Add(2);//S
        destroy.Add(3);
        destroy.Add(3);
        destroy.Add(1);//E
        destroy.Add(1);
        destroy.Add(2);//L
        destroy.Add(3);
        destroy.Add(3);
        destroy.Add(1);//P
        destroy.Add(1);//O
        destroy.Add(3);//C
        destroy.Add(3);//Rw
        destroy.Add(3);
        destroy.Add(1);//Re
        destroy.Add(1);
        destroy.Add(2);//Rs
        destroy.Add(2);

        //buildingN 0
        calcCoordinate(ref destination00, -16, 126, -13, 126);
        calcCoordinate(ref destination01, 2, 131, 5, 131);
        calcCoordinate(ref destination02, 20, 126, 23, 126);
        buildingN.Add(destination00);
        buildingN.Add(destination01);
        buildingN.Add(destination02);
        destinations.Add(buildingN);

        //buindingS 1
        calcCoordinate(ref destination03, -16, 115, -13, 115);
        calcCoordinate(ref destination04, -2, 100, -2, 103);
        calcCoordinate(ref destination05, -2, 70, -2, 73);
        buildingS.Add(destination03);
        buildingS.Add(destination04);
        buildingS.Add(destination05);
        destinations.Add(buildingS);

        //buildingE 2
        calcCoordinate(ref destination06, 9, 100, 9, 103);
        calcCoordinate(ref destination07, 9, 70, 9, 73);
        buildingE.Add(destination06);
        buildingE.Add(destination07);
        destinations.Add(buildingE);

        //buildingL 3
        calcCoordinate(ref destination08, -12, 50, -11, 50);
        calcCoordinate(ref destination09, -2, 40, -2, 41);
        calcCoordinate(ref destination10, -2, 22, -2, 23);
        buildingL.Add(destination08);
        buildingL.Add(destination09);
        buildingL.Add(destination10);
        destinations.Add(buildingL);

        //buildingP 4
        calcCoordinate(ref destination11, 9, 39, 9, 42);
        buildingP.Add(destination11);
        destinations.Add(buildingP);

        //buildingO 5
        calcCoordinate(ref destination12, 9, 22, 9, 23);
        buildingO.Add(destination11);
        destinations.Add(buildingO);

        //buildingC 6
        calcCoordinate(ref destination13, -2, 10, -2, 11);
        buildingC.Add(destination13);
        destinations.Add(buildingC);

        //buildingRw 7
        calcCoordinate(ref destination14, -22, 59, -22, 61);
        calcCoordinate(ref destination15, -22, 50, -22, 52);
        buildingRw.Add(destination14);
        buildingRw.Add(destination15);
        destinations.Add(buildingRw);

        //buildingRe 8
        calcCoordinate(ref destination16, 24, 59, 24, 61);
        calcCoordinate(ref destination17, 24, 50, 24, 52);
        buildingRe.Add(destination16);
        buildingRe.Add(destination17);
        destinations.Add(buildingRe);

        //buildingRs 9
        calcCoordinate(ref destination18, -2, 4, 0, 4);
        calcCoordinate(ref destination19, 7, 4, 9, 4);
        buildingRs.Add(destination18);
        buildingRs.Add(destination19);
        destinations.Add(buildingRs);

        //wayPoints
        calcCoordinate(ref wayPoint00, -6, 115, -5, 126);
        calcCoordinate(ref wayPoint01, 12, 115, 13, 126);
        calcCoordinate(ref wayPoint02, -2, 111, 3, 112);
        calcCoordinate(ref wayPoint03, 4, 111, 9, 112);
        calcCoordinate(ref wayPoint04, -2, 59, 3, 61);
        calcCoordinate(ref wayPoint05, 4, 59, 9, 61);
        calcCoordinate(ref wayPoint06, -2, 50, 0, 52);
        calcCoordinate(ref wayPoint07, 7, 50, 9, 52);

        for(int i = 0;i < destinations.Count; i++)
        {
            for(int j = 0;j < destinations[i].Count; j++)
            {
                wayPoints.Add(destinations[i][j]);
                for(int k = 0;k < destinations[i][j].Count; k++)
                {
                    //Debug.Log(destinations[i][j][k]);
                }
            }
        }

        wayPoints.Add(wayPoint00);
        wayPoints.Add(wayPoint01);
        wayPoints.Add(wayPoint02);
        wayPoints.Add(wayPoint03);
        wayPoints.Add(wayPoint04);
        wayPoints.Add(wayPoint05);
        wayPoints.Add(wayPoint06);
        wayPoints.Add(wayPoint07);

        connection00 = new List<int>() { 3, 20 };
        connection01 = new List<int>() { 20, 22, 23 };
        connection02 = new List<int>() { 21 };
        connection03 = new List<int>() { 0, 20 };
        connection04 = new List<int>() { 6, 7, 22, 23, 24, 25 };
        connection05 = new List<int>() { 6, 7, 22, 23, 24, 25 };
        connection06 = new List<int>() { 4, 5, 22, 23, 24, 25 };
        connection07 = new List<int>() { 4, 5, 22, 23, 24, 25 };
        connection08 = new List<int>() { 26 };
        connection09 = new List<int>() { 26 };
        connection10 = new List<int>() { 26 };
        connection11 = new List<int>() { 27 };
        connection12 = new List<int>() { 27 };
        connection13 = new List<int>() { 26 };
        connection14 = new List<int>() { 24 };
        connection15 = new List<int>() { 26 };
        connection16 = new List<int>() { 25 };
        connection17 = new List<int>() { 27 };
        connection18 = new List<int>() { 26 };
        connection19 = new List<int>() { 27 };
        connection20 = new List<int>() { 0, 1, 3, 21, 22 };
        connection21 = new List<int>() { 2, 20, 23 };
        connection22 = new List<int>() { 1, 4, 5, 6, 7, 20, 23, 24, 25 };
        connection23 = new List<int>() { 1, 4, 5, 6, 7, 21, 22, 24, 25 };
        connection24 = new List<int>() { 4, 5, 6, 7, 14, 22, 23, 25, 26 };
        connection25 = new List<int>() { 4, 5, 6, 7, 16, 22, 23, 24, 27 };
        connection26 = new List<int>() { 8, 9, 10, 13, 15, 18, 24, 27 };
        connection27 = new List<int>() { 11, 12, 17, 19, 25, 26 };

        connections.Add(connection00);
        connections.Add(connection01);
        connections.Add(connection02);
        connections.Add(connection03);
        connections.Add(connection04);
        connections.Add(connection05);
        connections.Add(connection06);
        connections.Add(connection07);
        connections.Add(connection08);
        connections.Add(connection09);
        connections.Add(connection10);
        connections.Add(connection11);
        connections.Add(connection12);
        connections.Add(connection13);
        connections.Add(connection14);
        connections.Add(connection15);
        connections.Add(connection16);
        connections.Add(connection17);
        connections.Add(connection18);
        connections.Add(connection19);
        connections.Add(connection20);
        connections.Add(connection21);
        connections.Add(connection22);
        connections.Add(connection23);
        connections.Add(connection24);
        connections.Add(connection25);
        connections.Add(connection26);
        connections.Add(connection27);

        /*
        for (int i = 0;i < destination04.Count; i++)
        {
            Debug.Log(destination04[i]);
        }
        */
        /*
        //test startを0,buildingN(0)とする goalを" 19 buildingRs(9) "とする
        int start = 0;
        int goal = 19;
        Queue<int> bfs = new Queue<int>();
        int[] dist = new int[28];
        for(int i = 0;i < dist.Length; i++)
        {
            dist[i] = -1;
        }
        bfs.Enqueue(start);
        dist[start] = 0;
        //Debug.Log(bfs.Count);
        while(bfs.Count != 0)
        {
            int currentPoint = bfs.Dequeue();
            //Debug.Log(currentPoint);
            for(int i = 0;i < connections[currentPoint].Count; i++)
            {
                int nextPoint = connections[currentPoint][i];
                //Debug.Log(nextPoint);
                if(nextPoint == goal)
                {
                    dist[nextPoint] = dist[currentPoint] + 1;
                    break;
                }
                if(dist[nextPoint] == -1)
                {
                    //Debug.Log(nextPoint);
                    bfs.Enqueue(nextPoint);
                    dist[nextPoint] = dist[currentPoint] + 1;
                }
            }
            if(dist[goal] != -1)
            {
                break;
            }
        }
        List<int> route = new List<int>();
        route.Add(goal);
        int beforePoint = goal;
        int n;
        int rand;
        for(int i = 0;i < dist[goal] - 1;i++)
        {
            //Debug.Log(beforePoint);
            n = connections[beforePoint].Count;
            for (int j = 0; j < n; j++)
            {
                rand = Random.Range(0, connections[beforePoint].Count);
                if (dist[connections[beforePoint][rand]] == dist[beforePoint] - 1)
                {
                    beforePoint = connections[beforePoint][rand];
                    route.Add(beforePoint);
                    break;
                }
                connections[beforePoint].RemoveAt(rand);
            }
        }
        route.Add(start);
        route.Reverse();
        for(int i = 0;i < route.Count; i++)
        {
            Debug.Log(route[i]);
        }
        */
    }

    private void calcCoordinate(ref List<(float, float)> addList, float xS, float yS, float xG, float yG)
    {
        for(float i = xS;i <= xG;i++)
        {
            for(float j = yS;j <= yG; j++)
            {
                addList.Add((i, j));
            }
        }
    }
}
