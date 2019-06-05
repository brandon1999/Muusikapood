using System.Data.Entity;

public class MuusikapoodDb : DbContext
{
    public MuusikapoodDb()
    {

    }

    public System.Data.Entity.DbSet<Muusikapood.Models.Muusikapoed> Muusikadb { get; set; }
}