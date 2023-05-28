namespace bmarketomvc.Models.Entities;

public class AddressEntity
{
    public int Id { get; set; }
    public string Streetname { get; set; } = null!;
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string? Company { get; set; }

    public ICollection<UserEntity> Users { get; set; } = new HashSet<UserEntity>();
}
