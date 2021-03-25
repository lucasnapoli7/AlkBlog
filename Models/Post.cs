using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlkBlog.Models
{
    public class Post
    {
        public int ID { get; set; }
        [Display(Name = "Creation date")]
        public DateTime creationDate { get; set; }
        [Required]
        [StringLength(100,MinimumLength =1)]
        [Display(Name = "Title")]
        public string title { get; set; }
        [Required]
        [MinLength(1)]
        [Display(Name = "Content")]
        public string content { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        [Required]
        [Display(Name = "Category")]
        public Category category { get; set; }
        public bool isDeleted { get; set; }
        public Post()
        {

        }
    }
}
