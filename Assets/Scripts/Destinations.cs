using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destinations : MonoBehaviour
{
    List<List<(float, float)>> wayPoints = new List<List<(float, float)>>();
    List<List<int>> connections = new List<List<int>>();
    List<List<List<(float, float)>>> destinations = new List<List<List<(float, float)>>>();
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

    private void Start()
    {
        //buildingN 0
        calcCoordinate(ref destination00, -16, 135, -13, 135);
        calcCoordinate(ref destination01, 2, 135, 5, 135);
        calcCoordinate(ref destination02, 20, 135, 23, 135);
        buildingN.Add(destination00);
        buildingN.Add(destination01);
        buildingN.Add(destination02);
        destinations.Add(buildingN);

        //buindingS 1
        calcCoordinate(ref destination03, -16, 108, -13, 108);
        calcCoordinate(ref destination04, -5, 100, -5, 103);
        calcCoordinate(ref destination05, -16, 70, -13, 73);
        buildingS.Add(destination03);
        buildingS.Add(destination04);
        buildingS.Add(destination05);
        destinations.Add(buildingS);

        //buildingE 2
        calcCoordinate(ref destination06, 12, 100, 12, 103);
        calcCoordinate(ref destination07, 12, 70, 12, 73);
        buildingE.Add(destination06);
        buildingE.Add(destination07);
        destinations.Add(buildingE);

        //buildingL 3
        calcCoordinate(ref destination08, -12, 47, -11, 47);
        calcCoordinate(ref destination09, -5, 40, -5, 41);
        calcCoordinate(ref destination10, -5, 22, -5, 23);
        buildingL.Add(destination08);
        buildingL.Add(destination09);
        buildingL.Add(destination10);
        destinations.Add(buildingL);

        //buildingP 4
        calcCoordinate(ref destination11, 12, 39, 12, 42);
        buildingP.Add(destination11);
        destinations.Add(buildingP);

        //buildingO 5
        calcCoordinate(ref destination12, 12, 22, 12, 23);
        buildingO.Add(destination11);
        destinations.Add(buildingO);

        //buildingC 6
        calcCoordinate(ref destination13, -5, 10, -5, 11);
        buildingC.Add(destination13);
        destinations.Add(buildingC);

        //buildingRw 7
        calcCoordinate(ref destination14, -25, 59, -25, 61);
        calcCoordinate(ref destination15, -25, 50, -25, 52);
        buildingRw.Add(destination14);
        buildingRw.Add(destination15);
        destinations.Add(buildingRw);

        //buildingRe 8
        calcCoordinate(ref destination16, 27, 59, 27, 61);
        calcCoordinate(ref destination17, 27, 50, 27, 52);
        buildingRe.Add(destination16);
        buildingRe.Add(destination17);
        destinations.Add(buildingRe);

        //buildingRs 9
        calcCoordinate(ref destination18, -2, 0, 0, 0);
        calcCoordinate(ref destination19, 7, 0, 9, 0);
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
        for(int i = 0;i < dist[goal] - 1;i++)
        {
            //Debug.Log(beforePoint);
            for (int j = 0; j < connections[beforePoint].Count; j++)
            {
                if (dist[connections[beforePoint][j]] == dist[beforePoint] - 1)
                {
                    beforePoint = connections[beforePoint][j];
                    route.Add(beforePoint);
                    break;
                }
            }
        }
        route.Add(start);
        route.Reverse();
        for(int i = 0;i < route.Count; i++)
        {
            Debug.Log(route[i]);
        }
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
