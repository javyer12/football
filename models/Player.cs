namespace eframework.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Player 
{
    public Guid PlayerId { get; set;}
    public string Name { get; set;}
    public string LastName { get; set;}
    public int Age { get; set;}
    public string Position {get;set;}
    public string LastClub { get; set;}
    public string CurrentClub { get; set;}
    public string Image { get; set;}
    // public virtual ICollection<Club> Club{ get; set}
    // public virtual ICollection<NFT> NTF{ get; set}
}