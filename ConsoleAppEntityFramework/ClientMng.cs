// See https://aka.ms/new-console-template for more information

using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEntityFramework
{
    public class ClientMng : EntityMng<Client>
	{
		public ClientMng(DbSet<Client> set) : base(set)
		{
		}

		public override bool ContainsId(Guid id)
		{
			return _set.ToList().Find(x => x.UserID == id) != null;
		}

		public override Client GetByID(Guid id)
		{
			return _set.FirstOrDefault(x => x.UserID == id);
		}

		public override void RemoveId(Guid id)
		{
			var v  = GetByID(id);
			if (v != null)
				Remove(v);
		}
	}


}

