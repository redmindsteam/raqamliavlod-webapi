using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Contests;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Courses;
using RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Questions;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Users;
using RaqamliAvlod.Infrastructure.Service.Managers;
using RaqamliAvlod.Infrastructure.Service.Security;
using RaqamliAvlod.Infrastructure.Service.Services.Common;
using RaqamliAvlod.Infrastructure.Service.Services.Contests;
using RaqamliAvlod.Infrastructure.Service.Services.Courses;
using RaqamliAvlod.Infrastructure.Service.Services.ProblemSets;
using RaqamliAvlod.Infrastructure.Service.Services.Questions;
using RaqamliAvlod.Infrastructure.Service.Services.Users;

namespace RaqamliAvlod.Api.Configurations.Dependencies
{
    public static class ServiceLayerConfiguration
    {
        public static void AddServiceLayer(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPaginatorService, PaginatorService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<ICourseCommentService, CourseCommentService>();
            builder.Services.AddScoped<ICourseVideoService, CourseVideoService>();
            builder.Services.AddScoped<IFileService, FileService>();
            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.AddScoped<IAuthManager, AuthManager>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IIdentityHelperService, IdentityHelperService>();
            builder.Services.AddScoped<IQuestionService, QuestionService>();
            builder.Services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();
            builder.Services.AddScoped<ITagService, TagService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IQuestionTagService, QuestionTagService>();
            builder.Services.AddScoped<IProblemSetService, ProblemSetService>();
            builder.Services.AddScoped<IContestService, ContestService>();
            builder.Services.AddScoped<IProblemSetTestService, ProblemSetTestService>();
            builder.Services.AddMemoryCache();
        }
    }
}
