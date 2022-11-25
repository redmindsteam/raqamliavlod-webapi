using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.Application.ViewModels.Contests
{
    public class ContestStandingsViewModel
    {
        public int ResultCoins { get; set; }
        public int Penalty { get; set; }

        public string Username { get; set; } = string.Empty;
        public string ContestName { get; set; } = string.Empty;

        public static implicit operator ContestStandingsViewModel(ContestStanding contest)
        {
            return new ContestStandingsViewModel()
            {
                ResultCoins = contest.ResultCoins,
                Penalty = contest.Penalty,
            };
        }
    }
}
