using System;
using System.Web.Http;
using VerismoTest.BLL;

public class TasksController : ApiController
{
	/// <summary>
	/// Create
	/// </summary>
	public IHttpActionResult Post(Task task)
	{
		Task existingTask = new Task(task.ID);

		if (existingTask.ID == task.ID)
		{
			return Conflict();
		}
		else
		{
			task.Save();
			return Ok(task);
		}
	}

	/// <summary>
	/// Retrieve (One)
	/// </summary>
	public IHttpActionResult Get(Guid id)
	{
		Task task = new Task(id);

		if (task.ID != id)
		{
			return NotFound();
		}
		else
		{
			return Ok(task);
		}
	}

	/// <summary>
	/// Retrieve (All)
	/// </summary>
	public IHttpActionResult Get()
	{
		return Ok(Task.RetrieveAll());
	}

	/// <summary>
	/// Update (Modify)
	/// </summary>
	public IHttpActionResult Patch(Task task)
	{
		Task existingTask = new Task(task.ID);

		if (existingTask.ID != task.ID)
		{
			return NotFound();
		}
		else
		{
			existingTask.Name = task.Name;
			existingTask.DueDate = task.DueDate;
			existingTask.Description = task.Description;
			existingTask.Save();
			return Ok(task);
		}
	}

	/// <summary>
	/// Update (Replace)
	/// </summary>
	public IHttpActionResult Put(Task task)
	{
		Task existingTask = new Task(task.ID);

		if (existingTask.ID != task.ID)
		{
			return NotFound();
		}
		else
		{
			existingTask.Delete();
			existingTask = task;
			existingTask.Save();
			return Ok(task);
		}
	}

	/// <summary>
	/// Delete
	/// </summary>
	public IHttpActionResult Delete(Guid id)
	{
		Task task = new Task(id);

		if (task.ID != id)
		{
			return NotFound();
		}
		else
		{
			task.Delete();
			return Ok(task);
		}
	}
}