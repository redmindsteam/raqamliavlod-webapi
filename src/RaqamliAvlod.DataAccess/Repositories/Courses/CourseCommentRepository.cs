
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.Domain.Entities.Courses;


namespace RaqamliAvlod.DataAccess.Repositories.Courses
{
    public class CourseCommentRepository : ICourseCommentRepository
    {
        private readonly AppDbContext _dbSet;

        public CourseCommentRepository(AppDbContext context)
        {
            _dbSet = context;
        }
        public async Task<CourseComment> CreateAsync(CourseComment entity)
        {
            await _dbSet.CourseComments.AddAsync(entity);
            await _dbSet.SaveChangesAsync();

            return entity;

        }

        public async Task<CourseComment> DeleteAsync(long id)
        {
            var entity = await _dbSet.CourseComments.FindAsync(id);
            if (entity is not null)
            {
                _dbSet.Remove(entity);
                await _dbSet.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to remove");
        }

        public async Task<CourseComment?> FindByIdAsync(long id)
        {
            return await _dbSet.CourseComments.FindAsync(id);
        }

        public async Task<CourseComment> UpdateAsync(long id, CourseComment entity)
        {
            var oldEntity = await _dbSet.CourseComments.FindAsync(id);
            if (oldEntity is not null)
            {
                entity.Id = id;
                _dbSet.CourseComments.Update(entity);
                await _dbSet.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to update");
        }
    }
}
