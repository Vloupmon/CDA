using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiContacts.Models
{
    
    public class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }

    [Owned]
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Geo Geo { get; set; }
    }
    [Owned]
    public class Geo
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }  

    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
