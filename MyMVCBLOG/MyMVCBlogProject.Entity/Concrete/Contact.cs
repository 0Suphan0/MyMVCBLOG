using MyMVCBlogProject.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyMVCBlogProject.Entity.Concrete
{
    public class Contact: IEntitiy
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Soyadı"), StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50), EmailAddress]
        public string? Email { get; set; }
        [Display(Name = "Mesaj"), StringLength(500)]
        public string Message { get; set; }
        [Display(Name = "Telefon"), StringLength(20)]
        public string? Phone { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;

        
    }
}
