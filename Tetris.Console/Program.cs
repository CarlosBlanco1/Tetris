﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Board()
{
    public static IEnumerable<List<string>>? CreateBoard(int columns, int rows)
    {
        if(columns > 0)
        {
            return new List<List<string>>(){new List<string>()};
        }
        return new List<List<string>>(){};
    }
}
