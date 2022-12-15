using UnityEngine;

public interface ISelectable : IHealthHolder
{
    Sprite Icon { get; }
    Transform ObjectTransform { get; }
}
