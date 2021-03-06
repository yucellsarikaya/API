// <auto-generated />
using DataAccess.Concrete.EntityFremework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20211212094156_personAddTableMg")]
    partial class personAddTableMg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(24)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("id");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
