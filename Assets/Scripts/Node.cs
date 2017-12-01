﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {
    //G = distance from the last "call"
    //H = distance between the target's path
    float m_G, m_H;
    Node m_parent;
    Maze m_maze;
    CellTest m_belongsTo;

    public Maze Maze
    {
        get { return m_maze; }
        set { m_maze = value; }
    }

    public float G
    {
        get { return m_G; }
        set { m_G = value; }
    }

    public float H
    {
        get { return m_H; }
        set { m_H = value; }
    }

    public float F
    {
        get { return m_G + m_H; }
    }

    public CellTest Cell
    {
        get { return m_belongsTo; }
    }

    public Node Parent
    {
        get { return m_parent; }
        set { m_parent = value; }
    }

    public List<Node> Neighbors
    {
        get
        {
            List<Node> list = new List<Node>();

            foreach (var neighborCell in m_belongsTo.NeighborList)
            {
                list.Add(neighborCell.Node);
            }

            return list;
        }
    }

    public Node(Maze _maze, CellTest _belongsTo, float _G = Mathf.Infinity)
    {
        Debug.Log("dans Node() appartient à : " + _belongsTo.Node);
        m_maze = _maze;
        m_belongsTo = _belongsTo;
        m_G = _G;
        m_H = 0;
        m_parent = null;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
