﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SomeonePointer : MonoBehaviour
{
    public List<(float, float)> someonePoints;
    private void Start()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Home":
                someonePoints = new List<(float, float)>()
                {

                };
                break;
            case "MainRoad":
                someonePoints = new List<(float, float)>()
                {

                };
                break;
            case "Academy":
                someonePoints = new List<(float, float)>()
                {

                };
                break;
            default:
                someonePoints = new List<(float, float)>()
        {
            (-1,3),
            (-1,4),
            (-2,3),
            (-4,3),
            (-4,4),
            (-7,5),
            (-10,4),
            (-12,5),
            (-13,5),
            (-14,5),
            (-13,4),
            (-14,4),
            (-15,2),
            (-15,1),
            (-13,7),(-14,7),(-13,8),(-14,8),
            (-10,9),(-9,9),(-9,8),
            (-4,10),(-3,10),(-2,10),(-4,9),(-3,9),(-2,9),(-4,8),(-3,8),(-2,8),(-3,7),(-2,7),
            (-7,11),(-8,11),
            (-13,11),(-14,12),(-15,12),
            (-13,14),(-12,15),
            (-11,13),(-10,13),(-9,13),
            (-4,13),(-3,13),(-2,13),(-3,14),
            (-3,17),(-4,17),
            (-3,19),(-2,19),(-3,20),(-4,20),(-5,20),
            (-8,18),
            (-10,17),(-11,18),
            (-14,18),(-15,18),
            (-14,21),(-13,21),(-14,22),(-13,22),(-12,23),
            (-9,21),(-9,20),
            (-13,25),(-14,26),(-15,26),(-13,27),
            (-10,25),(-10,24),
            (-3,23),
            (-3,25),(-3,26),(-2,25),(-4,25),(-5,26),(-6,26),(-7,26),(-6,25),(-5,24),
            (-9,30),(-8,30),
            (-13,31),(-13,32),(-14,31),(-15,31),(-15,32),
            (-4,32),(-3,31),
            (0,33),
            (-13,37),
            (-11,39),
            (-13,42),(-13,43),(-13,44),
            (-5,39),(-5,38),(-5,37),
            (0,38),(1,39),(0,40),
            (0,43),(-1,43),(-2,43),(-3,43),(-1,44),(-2,44),
            (5,44),(5,43),(5,42),
            (5,37),(5,36),(6,36),
            (9,39),(9,40),
            (9,44),(10,44),(11,43),
            (2,33),(2,34),(3,33),(4,33),(3,32),(4,32),
            (7,33),(8,34),(9,34),(10,34),(11,34),(12,34),(13,34),(14,34),(15,34),(16,34),(9,33),(10,33),(11,33),(12,33),(13,33),(14,33),(15,33),(16,33),(11,32),(12,32),(13,32),(14,32),
            (16,37),
            (20,38),(21,38),(22,38),(20,39),(21,39),(22,39),(22,40),
            (15,43),(15,44),(14,43),
            (20,43),(21,43),(22,43),(23,43),(21,44),(22,44),
            (20,33),(21,33),
            (23,33),(24,33),(25,33),(24,32),(25,32),
            (31,32),
            (33,31),(34,31),(35,31),(34,32),(35,32),(34,33),(35,33),(33,34),(34,34),(35,34),
            (31,37),(32,38),
            (40,38),(40,39),(40,37),
            (29,42),(28,43),(29,43),(30,43),(28,44),(29,44),(30,44),(31,44),
            (36,44),
            (36,42),
            (41,43),(42,42),(42,43),(42,44),(43,42),(43,43),(43,44),(44,44),(45,44),(44,43),(45,43),(46,43),
            (41,34),(41,33),(41,32),(41,31),(42,31),(42,32),(43,32),(44,33),(45,33),
            (47,34),(47,36),(47,37),(47,38),(48,40),(48,39),(48,38),(48,37),(48,36),(48,35),(48,34),(48,33),(48,32),(49,40),(49,39),(49,38),(49,37),(49,36),(49,35),(49,34),(49,33),(47,31),(46,31),(46,30),(45,30),
            (47,28),(47,27),(47,26),(48,26),(46,25),(46,24),
            (48,24),
            (48,18),(47,18),(47,19),(46,19),
            (52,34),(53,33),
            (56,31),
            (59,33),(59,34),
            (62,31),(63,32),
            (66,33),(67,33),(67,34),
            (60,43),(60,44),(59,43),
            (63,43),
            (66,42),(67,42),(67,41),
            (70,41),(70,42),
            (73,41),(74,41),
            (73,44),(74,44),
            (77,42),(78,42),
            (81,44),
            (81,41),(82,41),
            (70,31),(70,32),(71,32),(72,32),
            (75,33),(75,34),
            (78,33),(78,34),(79,33),(79,34),
            (83,34),
            (83,31),(82,31),(84,31),
            (89,49),(88,49),
            (89,45),(88,45),(87,46),(87,45),(87,44),(86,44),(85,44),(84,44),(85,43),
            (96,44),(97,43),(98,43),(98,44),(99,42),
            (96,40),(96,39),(97,39),(97,38),(96,37),
            (99,35),(99,34),(98,34),
            (98,31),(98,30),(98,29),(99,29),(99,28),
            (86,34),(86,33),
            (88,31),
            (87,28),(86,28),
            (88,24),
            (87,20),(87,19),(86,19),
            (98,25),(98,24),(98,23),(99,23),
            (96,20),(96,19),(97,19),
            (88,16),
            (97,15),
            (87,11),(86,11),
            (98,9),(99,9),
            (87,7),
            (88,3),
            (96,1),(97,1),
            (87,-3),(86,-3),
            (88,-8),(89,-8),
            (98,-5),(99,-5),(99,-4),(98,-4),
            (86,-15),
            (88,-18),(88,-19),
            (96,-13),(96,-12),(96,-11),(97,-11),
            (98,-18),(98,-19),(99,-18),(99,-19),
            (86,-23),(86,-24),(86,-25),(87,-25),
            (96,-24),(97,-24),
        };
                break;
        } 
    }
}