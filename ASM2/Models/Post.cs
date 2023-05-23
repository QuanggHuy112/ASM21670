using System;
namespace ASM2.Models
{
	public class Post
	{
        public string Id { set; get; }
        public string? Title { set; get; }
        public string? Description { set; get; }
        public string? CreatedOn { get; set; }
    }
}

