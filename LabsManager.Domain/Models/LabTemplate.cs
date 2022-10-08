using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.Domain.Models
{
    public class LabTemplate
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Theme { get; set; }
        public string TeacherFullName { get; set; }
        public string StudentFullName { get; set; }
        public string StudentGroup { get; set; }
        public string Purpose { get; set; }
    }
}
