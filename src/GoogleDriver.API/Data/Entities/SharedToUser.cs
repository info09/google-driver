using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoogleDriver.API.Data.Entities;

public class SharedToUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string OwnerUserName { get; set; }
    public string SharedUserName { get; set; }
    public string FullPath { get; set; }
    public string Url { get; set; }
    public string ShortUrl { get; set; }
    public bool IsFolder { get; set; }
    public string Name { get; set; }
}
