using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    bool Use {  get; }
    bool PickUp {  get; }
    bool Drop {  get; }
}
