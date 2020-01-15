using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExecStatusApp.Models
{
    public class ExecStats
    {
        [Required]
        public string Id { get; set; }
     
        public DateTime Time { get; set; }
        public string SourceMachine { get; set; }
        public string AppName { get; set; }
        public string Task { get; set; }
        public int Status { get; set; }
        public int prop1 { get; set; }
        public int prop2 { get; set; }
        public int prop3 { get; set; }

        public void getUTC()
        {
            //convert epoch to UTC
            DateTime newTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            //add epoch seconds
            newTime = newTime.AddSeconds(Int64.Parse(this.Id));
            //convert to UTC
            this.Time = newTime.ToUniversalTime();
        }
    }
}