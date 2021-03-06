﻿using System;

namespace VampireConsole
{
    using VampireDrama;
    using UnityEngine;

    class Program
    {
        static void Main(string[] args)
        {
            // 40, 41, 48, 57, 58, 59, 65
            Random.InitState(1);

            SceneManager sceneManager = new SceneManager();
            sceneManager.InitScene(3);

            var layout = sceneManager.currentMap.GetFullmap();

            foreach (var line in layout)
            {
                foreach (var construct in line)
                {
                    if (construct.Id == ConstructionType.Dumpster)
                    {
                        Console.Write('X');
                    }
                    else if (construct.Id == ConstructionType.Building)
                    {
                        if (construct.Dir == ConstructHVDirection.Horizontal)
                        {
                            Console.Write('=');
                        }
                        else if (construct.Dir == ConstructHVDirection.Vertical)
                        {
                            Console.Write('|');
                        }
                        else
                        {
                            Console.Write('?');
                        }
                    }
                    else if (construct.Id == ConstructionType.Road)
                    {
                        Console.Write(' ');
                    }
                    else if (construct.Id == ConstructionType.Water)
                    {
                        if (construct.Dir == ConstructHVDirection.Horizontal)
                        {
                            Console.Write(',');
                        }
                        else if (construct.Dir == ConstructHVDirection.Vertical)
                        {
                            Console.Write('^');
                        }
                        else
                        {
                            Console.Write('?');
                        }
                    }
                    else if (construct.Id == ConstructionType.Bridge)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('!');
                    }
                }

                Console.Write('\n');
            }
        }
    }
}
