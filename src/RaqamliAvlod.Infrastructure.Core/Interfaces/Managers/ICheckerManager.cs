using RaqamliAvlod.Infrastructure.Core.Models;

namespace RaqamliAvlod.Infrastructure.Core.Interfaces.Managers
{
    public interface ICheckerManager
    {
        public Task SendAsync(CheckerSubmissionDetails submissionDetails);

        public Task ReceiveAsync(CheckerSubmissionResponse submissionResponse);
    }
}