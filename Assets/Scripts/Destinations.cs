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

    private void Start()
    {
        //buildingN
        calcCoordinate(ref destination00, -16, 135, -13, 135);
        calcCoordinate(ref destination01, 2, 135, 5, 135);
        calcCoordinate(ref destination02, 20, 135, 23, 135);
        buildingN.Add(destination00);
        buildingN.Add(destination01);
        buildingN.Add(destination02);
        destinations.Add(buildingN);

        //buindingS
        calcCoordinate(ref destination03, -16, 108, -13, 108);
        calcCoordinate(ref destination04, -5, 100, -5, 103);
        calcCoordinate(ref destination05, -16, 70, -13, 73);
        buildingS.Add(destination03);
        buildingS.Add(destination04);
        buildingS.Add(destination05);
        destinations.Add(buildingS);

        //buildingE
        calcCoordinate(ref destination06, 12, 100, 12, 103);
        calcCoordinate(ref destination07, 12, 70, 12, 73);
        buildingE.Add(destination06);
        buildingE.Add(destination07);
        destinations.Add(buildingE);

        //buildingL
        calcCoordinate(ref destination08, -12, 47, -11, 47);
        calcCoordinate(ref destination09, -5, 40, -5, 41);
        calcCoordinate(ref destination10, -5, 22, -5, 23);
        buildingL.Add(destination08);
        buildingL.Add(destination09);
        buildingL.Add(destination10);
        destinations.Add(buildingL);

        //buildingP
        calcCoordinate(ref destination11, 12, 39, 12, 42);
        buildingP.Add(destination11);
        destinations.Add(buildingP);

        //buildingO
        calcCoordinate(ref destination12, 12, 22, 12, 23);
        buildingO.Add(destination11);
        destinations.Add(buildingO);

        //buildingC
        calcCoordinate(ref destination13, -5, 10, -5, 11);
        buildingC.Add(destination13);
        destinations.Add(buildingC);

        //buildingRw
        calcCoordinate(ref destination14, -25, 59, -25, 61);
        calcCoordinate(ref destination15, -25, 50, -25, 52);
        buildingRw.Add(destination14);
        buildingRw.Add(destination15);
        destinations.Add(buildingRw);

        //buildingRe
        calcCoordinate(ref destination16, 27, 59, 27, 61);
        calcCoordinate(ref destination17, 27, 50, 27, 52);
        buildingRe.Add(destination16);
        buildingRe.Add(destination17);
        destinations.Add(buildingRe);

        //buildingRs
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

        /*
        for (int i = 0;i < destination04.Count; i++)
        {
            Debug.Log(destination04[i]);
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
