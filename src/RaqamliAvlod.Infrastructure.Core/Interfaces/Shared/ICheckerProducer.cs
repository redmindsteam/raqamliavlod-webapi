using RaqamliAvlod.Infrastructure.Core.Models;

namespace RaqamliAvlod.Infrastructure.Core.Interfaces.Shared
{
    public interface ICheckerProducer
    {
        public void Send(CheckerSubmissionRequest request);
    }
}