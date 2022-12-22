using UnityEngine;
using System.Threading.Tasks;

public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
{
    public override async Task ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log($"{name} patroling!");
    }
}
