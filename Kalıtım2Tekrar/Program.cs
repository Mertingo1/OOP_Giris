﻿// See https://aka.ms/new-console-template for more information


public class One
{
    public int one { get; set; }
    public One(int a)
    {

    }
}

public class Two
{
    public int two { get; set; }
    public Two()
    {

    }
}

public class Tree
{
    public int tree { get; set; }
    public Tree()
    {

    }
}

public class Four : One
{
    public int four { get; set; }
    public Four(int b) :base(b)
    {

    }
}