using CarModule.Domain.Common;
using CarModule.Domain.Entities;
using CarModule.Domain.StronglyIds;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarModule.Domain.EntityTypeConfigurations;

public sealed class CarMakeEntityTypeConfiguration : BaseAuditableEntityEntityTypeConfiguration<CarMake>
{
    public override void Configure(EntityTypeBuilder<CarMake> builder)
    {
        base.Configure(builder);
        
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(
                x => x.Value,
                x => new CarMakeId(x));

        builder
            .Property(x => x.Name)
            .IsRequired()
            .IsUnicode(false)
            .HasMaxLength(DataSchemaConstants.Default_Name_Length);
        
        builder
            .HasData(GetCarMakeDefaultData());
    }

    private static IEnumerable<CarMake> GetCarMakeDefaultData()
    {
        yield return new CarMake(new CarMakeId(Guid.Parse("7287E4D6-B648-46EA-B81D-CDBB7AD872DA")), "Toyota", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("9D16B331-B955-486D-9F4B-B5CF66A577AC")), "Ford", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("53481D9D-ACDF-41BB-B720-4A267536442D")), "Chevrolet", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("EAB78139-37BC-4DF6-A3E6-7446552469CA")), "Honda", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("E7E82A96-8602-4FCB-9DCF-59D3F1E6FEDC")), "Nissan", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("0D0C430F-76A9-4FD1-B1EE-8E7A0FED8D75")), "Jeep", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("99E4C746-59CB-43C3-B23D-E0FA0B4CDD3B")), "Hyundai", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("4DECF079-3F54-4C38-9A77-9B68D07956DE")), "Dodge", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("17C56FF4-ED4A-4B3B-B171-CEBAFFA2CCC6")), "Kia", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("87E75C03-91D8-49CE-B073-89D365FE59F0")), "BMW", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("B4700214-A16B-48BF-96FC-93928DB68063")), "Ram", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("01EED1BA-E980-42C7-BE5C-53B89CA44123")), "GMC", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("E8379AF2-AC28-4EA9-B272-C2B44D158C6C")), "Mercedes-Benz", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("20DC528D-0FDE-4551-A0B3-6C4027D39411")), "Subaru", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("220C821A-1331-472C-A02E-2303811A3A60")), "Volkswagen", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("D39BB50E-AB01-4ED3-A7DF-CE8B285AC987")), "Audi", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("A4938E80-588E-4CA1-B621-4400B0BB2467")), "Lexus", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("BB814475-6AA6-4113-8685-5484095BF05D")), "Mazda", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("421C4AF8-5874-45AE-8CAC-0129A1BC7751")), "Buick", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("80890A69-3175-4D7D-9A26-DFFE46F09B4D")), "Cadillac", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("1E46D67D-10A5-48DD-990E-6798FB55E8E1")), "Volvo", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("F8B41DF5-77C9-4490-8DF7-836A2038BBED")), "Lincoln", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("63C09DDD-EB45-4A18-8B0D-CABB4194EDCF")), "Land Rover", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("C9A81F4F-0CE7-427E-B0D3-FC8245EA35D9")), "Porsche", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("9FB88BAD-8658-463F-B5C3-8DD7EE5A88A4")), "Jaguar", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("B7FF96B6-E9CF-48EC-AAC7-74BD40AE4A1C")), "Acura", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("8544F301-EDB6-4DC8-9B8D-E8EFF68B878E")), "Infiniti", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("01033E6F-1D02-4A9A-AAF9-0678C21A158A")), "Mini", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("75880695-B23D-4CE2-A77A-A5021CD10505")), "Mitsubishi", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("3C94DDC7-ABAF-4F2C-BEF6-0DC5614DF837")), "Bentley", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("3A3E7ECD-41BC-47C1-80E6-49F3C898BE21")), "Fiat", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("A5C9CA04-DB41-421D-8C22-E86882F11F2F")), "Smart", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("33B0B393-8A2D-4D01-B2A9-FFF72A96473E")), "Scion", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("479344BC-520A-40E4-AF5C-50ADCCAE5484")), "Tesla", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("262E0D81-48A1-4A29-B0BF-49F84E0E49A9")), "Genesis", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("E9CA2BD2-20F3-447B-9E30-D6F536E69A55")), "Maserati", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("43E5B83D-32E6-47AC-A5C6-11C068B14CD6")), "Ferrari", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("5142099B-9355-407E-A229-1B307E71F201")), "Lamborghini", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("33740F26-AB9E-423A-80EE-643A971C870F")), "McLaren", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("6B285A80-5693-42FD-BAF2-8E1E4D499995")), "Rolls-Royce", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("36602F7C-35F7-4A6C-B1E3-E7C3B0E23B46")), "Bugatti", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("714ED326-9EDB-4B80-97F8-66DF5CA5392A")), "Koenigsegg", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("6DE8AC30-ECD2-43AA-B575-BA9A6D844BA6")), "Pagani", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("55AD59A4-2EC6-4FB0-A3A4-B9659781AEA1")), "Lotus", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("DEF12FF1-1CD2-473A-924F-8D9CA09E1C93")), "Alfa Romeo", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("2FE719AE-FA15-440A-A810-124563E065EE")), "Aston Martin", DateTimeOffset.Now);
        yield return new CarMake(new CarMakeId(Guid.Parse("DBFF39EE-0FEA-4C34-9DD4-C5054385EBC0")), "Bentley", DateTimeOffset.Now);
    }
}