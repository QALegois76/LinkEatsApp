// See https://aka.ms/new-console-template for more information

using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ConsoleAppEntityFramework
{
    public class RestaurantMng : EntityMng<Restaurant>
	{
		public RestaurantMng(DbSet<Restaurant> set) : base(set)
		{
		}

		public override bool ContainsId(Guid id)
		{
			return _set.ToList().Find(x=>x.UserID == id) != null;
		}

		public override Restaurant GetByID(Guid id)
		{
			return _set.ToList().Find(x => x.UserID == id);
		}

		public override void RemoveId(Guid id)
		{
			var v = GetByID(id);
			if (v != null)
				_set.Remove(v);
		}
	}


}

