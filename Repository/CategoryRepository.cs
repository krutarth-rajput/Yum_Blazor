using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Category> CreateAsync(Category obj)
        {
            await _db.Categories.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Category obj = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if(obj == null)
            {
                return false;
            }
            _db.Categories.Remove(obj);
            return (await _db.SaveChangesAsync()) > 0; //When we perform _db SaveChanges tells us no. of rows affected.
        }

        public async Task<Category> GetAsync(int id)
        {
            Category? obj = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (obj == null)
            {
                return null;
            }
            return obj;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {

            return await _db.Categories.ToListAsync();
        }

        public async Task<Category> UpdateAsync(Category obj)
        {

            Category? existingObj = await _db.Categories.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingObj == null) {
                return null;
            }
            
            existingObj.Name = obj.Name; // Update the properties you want to change so no unintentional changes are made
            _db.Categories.Update(existingObj);
            await _db.SaveChangesAsync();
            return existingObj;
        }
    }
}
