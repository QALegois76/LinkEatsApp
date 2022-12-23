// See https://aka.ms/new-console-template for more information

using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEntityFramework
{
    public class DeliverymanMng : EntityMng<Deliveryman>
	{
		public DeliverymanMng(DbSet<Deliveryman> set) : base(set)
		{
		}

		public override bool ContainsId(Guid id)
		{
			return GetByID(id) != null;
		}

		public override Deliveryman GetByID(Guid id)
		{
			return _set.ToList().Find(x => x.UserID == id);
		}

		public override void RemoveId(Guid id)
		{
			var v = GetByID(id);
			if (v != null)
				Remove(v);
		}
	}


}

