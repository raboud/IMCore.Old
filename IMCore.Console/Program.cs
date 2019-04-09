using IMCore.Data;
using IMCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMCore.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			IMCoreContext ctx = new IMCoreContext();
			List<PONote> notes = ctx.Ponotes.Where(n => n.SpokeWithId == 1).Take(10).ToList();
			List<SpokeWith> sw = ctx.SpokeWith.ToList();

			List<Item> items = ctx.Item.Where(i => i.Id == 133).Include(i => i.MaterialCategoryItemMappings).ThenInclude(mi => mi.MaterialCategory).ToList();
			System.Console.WriteLine("Hello World!");
		}
	}
}
