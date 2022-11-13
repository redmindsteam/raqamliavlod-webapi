using Microsoft.Extensions.Configuration;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Infrastructure.Core.Interfaces.Managers;
using RaqamliAvlod.Infrastructure.Core.Interfaces.Shared;
using RaqamliAvlod.Infrastructure.Core.Models;

namespace RaqamliAvlod.Infrastructure.Core.Managers
{
    public class CheckerManager : ICheckerManager
    {
        private readonly IConfigurationSection _config;
        private readonly ICheckerProducer _producer;
        private readonly IUnitOfWork _unitOfWork;
        public CheckerManager(IConfiguration configuration, ICheckerProducer checkerProducer, 
            IUnitOfWork unitOfWork)
        {
            this._config = configuration.GetSection("Checker");
            this._producer = checkerProducer;
            this._unitOfWork = unitOfWork;
        }

        public async Task ReceiveAsync(CheckerSubmissionResponse submissionResponse)
        {
            throw new NotImplementedException();
        }

        public async Task SendAsync(CheckerSubmissionDetails submissionDetails)
        {
            CheckerSubmissionRequest request = (CheckerSubmissionRequest)submissionDetails;
            request.IdentityKey = _config["IdentityKey"]!;
            request.Password = _config["Password"]!;
            _producer.Send(request);
        }
    }
}