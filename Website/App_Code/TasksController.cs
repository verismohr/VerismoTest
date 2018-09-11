using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using VerismoTest.BLL;

[RoutePrefix("api/tasks")]
[EnableCors(origins: "*", headers: "*", methods: "*")]
public class TasksController : ApiController
{
	[HttpPost]
	[Route("")]
	public IHttpActionResult Create([FromBody]Task task)
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

	[HttpGet]
	[Route("{id:guid}")]
	public IHttpActionResult RetrieveOne([FromUri]Guid id)
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

	[HttpGet]
	[Route("")]
	public IHttpActionResult RetrieveAll()
	{
		return Ok(Task.RetrieveAll());
	}

	[HttpPatch]
	[Route("")]
	public IHttpActionResult Modify([FromBody]Task task)
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
			return Ok(existingTask);
		}
	}

	[HttpPut]
	[Route("")]
	public IHttpActionResult Replace([FromBody]Task task)
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

	[HttpDelete]
	[Route("{id:guid}")]
	public IHttpActionResult Delete([FromUri]Guid id)
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

	[HttpGet]
	[Route("{startDate:datetime}/{endDate:datetime}")]
	public IHttpActionResult BetweenDates([FromUri]DateTime startDate, [FromUri]DateTime endDate)
	{
		return Ok(Task.RetrieveAll().Where(task => task.DueDate >= startDate && task.DueDate <= endDate));
	}
}