using JobListingProjesi.Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class BaseRepository<T> :IDisposable where T:class,new()
    {
        protected readonly JobListContext context = new JobListContext();
        public bool Add(T data)
        {
            try
            {
                context.Set<T>().Add(data);
                return context.SaveChanges()>0 ? true : false;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                T silinecekData=context.Set<T>().Find(id);
                context.Set<T>().Remove(silinecekData);
                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SoftDelete(T data)
        {
            try
            {
                context.Entry<T>(data).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges() > 0 ? true : false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool Update(T data)
        {
            try
            {
                context.Entry<T>(data).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Artık çağrıları algılama

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: yönetilen durumu (yönetilen nesneleri) bırakın.
                }

                // TODO: yönetilmeyen kaynakları (yönetilmeyen nesneleri) serbest bırakın ve aşağıda bir sonlandırıcıyı geçersiz kılın.
                // TODO: büyük alanları null olarak ayarlayın.

                disposedValue = true;
            }
        }

        // TODO: yalnızca yukarıdaki Dispose(bool disposing) ifadesi yönetilmeyen kaynakları serbest bırakacak koda sahipse sonlandırıcıyı geçersiz kılın.
        // ~BaseRepository()
        // {
        //   // Bu kodu değiştirmeyin. Temizleme kodunu yukarıdaki Dispose(bool disposing) içine yerleştirin.
        //   Dispose(false);
        // }

        // Atılabilir deseni doğru uygulamak için bu kod eklendi.
        public void Dispose()
        {
            // Bu kodu değiştirmeyin. Temizleme kodunu yukarıdaki Dispose(bool disposing) içine yerleştirin.
            Dispose(true);
            // TODO: sonlandırıcı yukarıda geçersiz kılınırsa aşağıdaki satırın açıklamasını kaldırın.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
