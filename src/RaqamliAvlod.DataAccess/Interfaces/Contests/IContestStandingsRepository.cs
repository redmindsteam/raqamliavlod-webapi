using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Interfaces.Contests
{
    public interface IContestStandingsRepository 
        : ICreateable<ContestStandings>, IFindable<ContestStandings>, IUpdateable<ContestStandings>
    {

    }
}
