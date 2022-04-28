using GartenCenter2.BAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GartenCenter2.Services
{
    public class ArticleServices
    {
        #region Property
        private readonly GartenContext _appDBContext;
        #endregion

        #region Constructor
        public ArticleServices(GartenContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Article
        public async Task<List<Article>> GetAllAsync()
        {
            return await _appDBContext.Articles.ToListAsync();
        }
        #endregion

        #region Insert Article
        public async Task<bool> InsertAsync(Article article)
        {
            await _appDBContext.Articles.AddAsync(article);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Article by Id
        public async Task<Article> GetByIdAsync(int Id)
        {
            Article Article = await _appDBContext.Articles.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return Article;
        }
        #endregion

        #region Update Article
        public async Task<bool> UpdateAsync(Article article)
        {
            _appDBContext.Articles.Update(article);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Article
        public async Task<bool> DeleteAsync(Article article)
        {
            _appDBContext.Remove(article);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
