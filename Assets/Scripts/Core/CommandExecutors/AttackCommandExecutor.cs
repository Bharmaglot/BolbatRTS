using UnityEngine;
using System.Threading.Tasks;

public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
{
    public override async Task ExecuteSpecificCommand(IAttackCommand command)
    {
        Debug.Log($"{name} is attacking!");
    }
}
