﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourcePoint : Interactable
{
    // -- PROPERTIES

    public bool IsDepleted => AmountOfResources == 0;

    // -- FIELDS

    public int AmountOfResources;


    // -- METHODS

    public void TakeResource(ControllableCharacter character)
    {
        if (IsDepleted)
        {
            return;
        }

        --AmountOfResources;
    }
}
