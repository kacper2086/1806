using System;
using System.ComponentModel.DataAnnotations;

public class ItemShop
{
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
}
