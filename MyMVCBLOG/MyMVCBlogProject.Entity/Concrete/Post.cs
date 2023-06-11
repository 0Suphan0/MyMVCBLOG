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
    public class Post: IEntitiy
    {

        public int Id { get; set; }
        [Display(Name = "Gönderi Adı"), StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Gönderi Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Gönderi Resmi"), StringLength(100)]
        public string? Image { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Güncellenme Tarihi")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public Category? Category { get; set; }



    }
}
