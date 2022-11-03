using RaqamliAvlod.Application.Utils;

namespace RaqamliAvlod.Infrastructure.Service.Interfaces.Common;

public interface IPaginatorService
{
    void ToPagenator(PaginationMetaData metaData);
}
