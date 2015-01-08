using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;
using VerismoTest.BLL;

namespace VerismoTest.Website
{
	public partial class Default : PageBaseClass
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Kodexempel för "Task" (CRUD)
			
			// Skapa ny Task (Create)
			Task task1 = new Task();
			task1.Name = "Mata katten";
			task1.DueDate = DateTime.Today.AddDays(7);
			task1.Description = "Viktigt!";
			task1.Save();

			// Hämta task (Retrieve)
			Task task2 = new Task(task1.ID);

			// Ändra värde på task (Update)
			task2.Description = "Inte så viktigt";
			task2.Save();

			// Ta bort task (Delete)
			task2.Delete();
		}
	}
}