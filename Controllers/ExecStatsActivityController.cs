using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ExecStatusApp.Data;
using ExecStatusApp.Models;
using System.Data.SqlClient;

namespace ExecStatusApp.Controllers
{
    public class ExecStatsActivityController : ApiController
    {
        private ExecStatusAppContext db = new ExecStatusAppContext();

        // GET: api/ExecStatsActivity
        public IQueryable<ExecStats> GetExecStatsActivity()
        {
            return db.ExecStats;
        }

        // GET: api/ExecStatsActivity/5
        [ResponseType(typeof(List<ExecStats>))]
        public async Task<IHttpActionResult> GetExecCStatsActivity(string id)
        {
            DbSqlQuery<ExecStats> query = db.ExecStats.SqlQuery("SELECT * FROM dbo.ExecStats WHERE Task = @task", new SqlParameter("@task", id));
            List<ExecStats> task_query = await query.ToListAsync();

            if (task_query == null)
            {
                return NotFound();
            }

            return Ok(task_query);
        }
    }
}