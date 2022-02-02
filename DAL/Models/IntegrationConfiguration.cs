using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class IntegrationConfiguration
    {
        public int Id { set; get; }
        public string? APIName { set; get; }
        public string? Verb { set; get; }
        public string? Headers { set; get; }
        public string? RequestBody { set; get; }
        public string? ResponseBody { set; get; }
        public bool? Active { set; get; }
        public DateTime? InsertionDate { set; get; }
        [ForeignKey("Organization")]
        public int? OrganizationId { set; get; }

        public Organization Organization { set; get; }
        public ICollection<IntegrationsTransactions> IntegrationsTransactions { set; get; }
    }
}
