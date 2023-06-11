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
    public class Category : IEntitiy

    {
    public int Id { get; set; }

    [Display(Name = "Kategori Adı"), StringLength(100)]
    public string Name { get; set; }

    [Display(Name = "Kategori Açıklaması")]
    public string? Description { get; set; }

    [Display(Name = "Kategori Resmi"), StringLength(100)]
    public string? Image { get; set; }

    [Display(Name = "Durum")] public bool IsActive { get; set; }
    [Display(Name = "Eklenme Tarihi")] public DateTime? CreateDate { get; set; } = DateTime.Now;
    public List<Post>? Posts { get; set; }


    }
}
