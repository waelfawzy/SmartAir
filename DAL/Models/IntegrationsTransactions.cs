using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class IntegrationsTransactions
    {
        public int Id { set; get; }
        public string? ResuestBody { set; get; }
        public string? ResponseBody { set; get; }
        public DateTime? InsertionDate { set; get; }
        [ForeignKey("IntegrationConfiguration")]
        public int? IntegrationConfigurationId { set; get; }
        public IntegrationConfiguration IntegrationConfiguration { set; get; }
    }
}
