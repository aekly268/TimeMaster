﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Card
{
    public int id;
    public CardType type;
    public string description;
    public string fileName;
}

public enum CardType
{
    Text,Image
}
