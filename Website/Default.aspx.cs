using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VerismoTest.BLL;

namespace Website
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ---------------------------------------------

            // Alternativ #1

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

            // ---------------------------------------------

            // Alternativ #2

            // Tasks REST API

            // Retrieve (All)	-> GET		-> http://localhost:63935/api/tasks
            // Delete			-> DELETE	-> http://localhost:63935/api/tasks/<guid>
            // Retrieve (One)	-> GET		-> http://localhost:63935/api/tasks/<guid>
            // Create			-> POST		-> http://localhost:63935/api/tasks + BODY
            // Update (Modify)	-> PATCH	-> http://localhost:63935/api/tasks + BODY
            // Update (Replace)	-> PUT		-> http://localhost:63935/api/tasks + BODY

            // ---------------------------------------------
        }
    }
}