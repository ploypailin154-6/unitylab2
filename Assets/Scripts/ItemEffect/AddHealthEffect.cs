using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(10);
        return false;
    }
}
