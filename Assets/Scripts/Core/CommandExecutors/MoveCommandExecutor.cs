using System.Threading;
using UnityEngine.AI;
using UnityEngine;
using System.Threading.Tasks;

public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
{
    [SerializeField] private UnitMovementStop _stop;
    [SerializeField] private Animator _animator;
    [SerializeField] private StopCommandExecutor _stopCommandExecutor;

    public override async Task ExecuteSpecificCommand(IMoveCommand command)
    {
        GetComponent<NavMeshAgent>().destination = command.Target;
        _animator.SetTrigger("Walk");
        
        _stopCommandExecutor.CancellationTokenSource = new CancellationTokenSource();
        try
        {
            await _stop.WithCancellation(_stopCommandExecutor.CancellationTokenSource.Token);
        }
        catch
        {
            GetComponent<NavMeshAgent>().isStopped = true;
            GetComponent<NavMeshAgent>().ResetPath();
        }
        _stopCommandExecutor.CancellationTokenSource = null;
        _animator.SetTrigger("Idle");

    }
}
