// See https://aka.ms/new-console-template for more information

using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ConsoleAppEntityFramework
{
    public class DiscountMng : EntityMng<Discount>
	{
		public DiscountMng(DbSet<Discount> set) : base(set)
		{
		}

		public override bool ContainsId(Guid id)
		{
			return GetByID(id) != null;
		}

		public override Discount GetByID(Guid id)
		{
			return _set.ToList().Find(x => x.DiscountID == id);
		}

		public override void RemoveId(Guid id)
		{
			var v = GetByID(id);
			if (v != null)
				Remove(v);
		}
	}


}

