using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data.Entities;

namespace SocialMedia.Data;

public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<int>, int>
{
    public DbSet<PostsEntity> Posts { get; set; }
    public DbSet<CommentsEntity> Comments{ get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options){}
    public DbSet<RepliesEntity> Replies{get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().ToTable("Users");
        // modelBuilder.Entity<PostsEntity>().HasKey(comment => comment.Id);       
    }
}