using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExecStatusApp.Models
{
    public class ExecStats
    {
        public string Id { get; set; }
        [Required]
        public string SourceMachine { get; set; }
        public string AppName { get; set; }
        public string Task { get; set; }
        public int Status { get; set; }
        public int prop1 { get; set; }
        public int prop2 { get; set; }
        public int prop3 { get; set; }
    }
}