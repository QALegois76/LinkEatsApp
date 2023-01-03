// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ConsoleAppEntityFramework
{
    public abstract class EntityMng<T> where T : class
	{
		internal event EventHandler OnSaveData;
		protected DbSet<T> _set;

		public EntityMng(DbSet<T> set)
		{
			_set = set;
		}

		public virtual void Add(T entity) => _set.Add(entity);
		public virtual void Update(T entity) => _set.Update(entity);
		public virtual void Remove(T entity) => _set.Remove(entity);
		public virtual void RemoveAt(int index) => _set.ToList().RemoveAt(index);
		public abstract void RemoveId(Guid id);
		public virtual bool Contains(T entity) => _set.Contains(entity);
		public abstract bool ContainsId(Guid id);
		public abstract T GetByID (Guid id);
		public virtual T GetAt(int i) => _set.ToArray()[i];
		public T[] GetAll() => _set.ToArray();
		public void SaveData()=> OnSaveData?.Invoke(this, EventArgs.Empty);
	}
}

