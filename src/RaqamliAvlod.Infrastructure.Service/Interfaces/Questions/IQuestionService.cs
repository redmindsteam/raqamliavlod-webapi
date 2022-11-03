using RaqamliAvlod.Domain.Entities.Questions;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using System.Linq.Expressions;

namespace RaqamliAvlod.Infrastructure.Service.Interfaces.Questions;

public interface IQuestionService
{
    Task<bool> UpdateAsync(QuestionUpdateDto questionUpdateViewModel);
    Task<bool> DeleteAsync(Expression<Func<Question, bool>> expression);
}
