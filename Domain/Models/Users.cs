using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Models;
[Table("Users")]
public class Users
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("user_id")]
    public int UserId { get; set; }
    [Column("user_name")]
    public string Name { get; set; }
    
    [Column("user_email")]
    [EmailAddress]
    public string Email { get; set; }
    [Column("user_password")]
    public string Password { get; set; }

}
