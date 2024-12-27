using BookApi.EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookApi.EntityFrameworkCore.Data;
public class CategoryContext(DbContextOptions<CategoryContext> options) : DbContext(options)
{
    public required DbSet<Category> Categories { get; set; }
    public required DbSet<Links> Links { get; set; }
    public required DbSet<LinkObject> LinkObject { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

                // Link objects
        // 12
        modelBuilder.Entity<LinkObject>().HasData(
new LinkObject { Id = 1, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/12") },
new LinkObject { Id = 2, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/12/books?offset=0&limit=50") },
new LinkObject { Id = 3, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/12?offset=0&limit=50") },
new LinkObject { Id = 4, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/13") },
new LinkObject { Id = 5, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/13/books?offset=0&limit=50") },
new LinkObject { Id = 6, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/13?offset=0&limit=50") },
new LinkObject { Id = 7, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/14") },
new LinkObject { Id = 8, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/14/books?offset=0&limit=50") },
new LinkObject { Id = 9, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/14?offset=0&limit=50") },
new LinkObject { Id = 10, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/15") },
new LinkObject { Id = 11, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/15/books?offset=0&limit=50") },
new LinkObject { Id = 12, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/15?offset=0&limit=50") },
new LinkObject { Id = 13, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/16") },
new LinkObject { Id = 14, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/16/books?offset=0&limit=50") },
new LinkObject { Id = 15, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/16?offset=0&limit=50") },
new LinkObject { Id = 16, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/17") },
new LinkObject { Id = 17, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/17/books?offset=0&limit=50") },
new LinkObject { Id = 18, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/17?offset=0&limit=50") },
new LinkObject { Id = 19, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/2") },
new LinkObject { Id = 20, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/2/books?offset=0&limit=50") },
new LinkObject { Id = 21, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/2?offset=0&limit=50") },
new LinkObject { Id = 22, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/5") },
new LinkObject { Id = 23, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/5/books?offset=0&limit=50") },
new LinkObject { Id = 24, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/5?offset=0&limit=50") },
new LinkObject { Id = 25, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/6") },
new LinkObject { Id = 26, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/6/books?offset=0&limit=50") },
new LinkObject { Id = 27, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/6?offset=0&limit=50") },
new LinkObject { Id = 28, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/8") },
new LinkObject { Id = 29, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/8/books?offset=0&limit=50") },
new LinkObject { Id = 30, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/8?offset=0&limit=50") },
new LinkObject { Id = 31, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/11") },
new LinkObject { Id = 32, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/11/books?offset=0&limit=50") },
new LinkObject { Id = 33, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/11?offset=0&limit=50") },
new LinkObject { Id = 34, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/177") },
new LinkObject { Id = 35, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/177/books?offset=0&limit=50") },
new LinkObject { Id = 36, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/177?offset=0&limit=50") },
new LinkObject { Id = 37, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/54") },
new LinkObject { Id = 38, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/54/books?offset=0&limit=50") },
new LinkObject { Id = 39, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/54?offset=0&limit=50") },
new LinkObject { Id = 40, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/160") },
new LinkObject { Id = 41, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/160/books?offset=0&limit=50") },
new LinkObject { Id = 42, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/160?offset=0&limit=50") },
new LinkObject { Id = 43, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/161") },
new LinkObject { Id = 44, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/161/books?offset=0&limit=50") },
new LinkObject { Id = 45, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/161?offset=0&limit=50") },
new LinkObject { Id = 46, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/55") },
new LinkObject { Id = 47, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/55/books?offset=0&limit=50") },
new LinkObject { Id = 48, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/55?offset=0&limit=50") },
new LinkObject { Id = 49, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/56") },
new LinkObject { Id = 50, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/56/books?offset=0&limit=50") },
new LinkObject { Id = 51, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/56?offset=0&limit=50") },
new LinkObject { Id = 52, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/57") },
new LinkObject { Id = 53, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/57/books?offset=0&limit=50") },
new LinkObject { Id = 54, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/57?offset=0&limit=50") },
new LinkObject { Id = 55, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/58") },
new LinkObject { Id = 56, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/58/books?offset=0&limit=50") },
new LinkObject { Id = 57, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/58?offset=0&limit=50") },
new LinkObject { Id = 58, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/59") },
new LinkObject { Id = 59, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/59/books?offset=0&limit=50") },
new LinkObject { Id = 60, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/59?offset=0&limit=50") },
new LinkObject { Id = 61, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/60") },
new LinkObject { Id = 62, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/60/books?offset=0&limit=50") },
new LinkObject { Id = 63, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/60?offset=0&limit=50") },
new LinkObject { Id = 64, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/61") },
new LinkObject { Id = 65, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/61/books?offset=0&limit=50") },
new LinkObject { Id = 66, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/61?offset=0&limit=50") },
new LinkObject { Id = 67, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/62") },
new LinkObject { Id = 68, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/62/books?offset=0&limit=50") },
new LinkObject { Id = 69, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/62?offset=0&limit=50") },
new LinkObject { Id = 70, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/63") },
new LinkObject { Id = 71, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/63/books?offset=0&limit=50") },
new LinkObject { Id = 72, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/63?offset=0&limit=50") },
new LinkObject { Id = 73, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/64") },
new LinkObject { Id = 74, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/64/books?offset=0&limit=50") },
new LinkObject { Id = 75, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/64?offset=0&limit=50") },
new LinkObject { Id = 76, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/65") },
new LinkObject { Id = 77, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/65/books?offset=0&limit=50") },
new LinkObject { Id = 78, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/65?offset=0&limit=50") },
new LinkObject { Id = 79, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/66") },
new LinkObject { Id = 80, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/66/books?offset=0&limit=50") },
new LinkObject { Id = 81, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/66?offset=0&limit=50") },
new LinkObject { Id = 82, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/67") },
new LinkObject { Id = 83, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/67/books?offset=0&limit=50") },
new LinkObject { Id = 84, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/67?offset=0&limit=50") },
new LinkObject { Id = 85, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/68") },
new LinkObject { Id = 86, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/68/books?offset=0&limit=50") },
new LinkObject { Id = 87, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/68?offset=0&limit=50") },
new LinkObject { Id = 88, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/27") },
new LinkObject { Id = 89, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/27/books?offset=0&limit=50") },
new LinkObject { Id = 90, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/27?offset=0&limit=50") },
new LinkObject { Id = 91, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/30") },
new LinkObject { Id = 92, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/30/books?offset=0&limit=50") },
new LinkObject { Id = 93, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/30?offset=0&limit=50") },
new LinkObject { Id = 94, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/32") },
new LinkObject { Id = 95, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/32/books?offset=0&limit=50") },
new LinkObject { Id = 96, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/32?offset=0&limit=50") },
new LinkObject { Id = 97, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/33") },
new LinkObject { Id = 98, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/33/books?offset=0&limit=50") },
new LinkObject { Id = 99, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/33?offset=0&limit=50") },
new LinkObject { Id = 100, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/48") },
new LinkObject { Id = 101, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/48/books?offset=0&limit=50") },
new LinkObject { Id = 102, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/48?offset=0&limit=50") },
new LinkObject { Id = 103, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/49") },
new LinkObject { Id = 104, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/49/books?offset=0&limit=50") },
new LinkObject { Id = 105, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/49?offset=0&limit=50") },
new LinkObject { Id = 106, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/50") },
new LinkObject { Id = 107, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/50/books?offset=0&limit=50") },
new LinkObject { Id = 108, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/50?offset=0&limit=50") },
new LinkObject { Id = 109, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/51") },
new LinkObject { Id = 110, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/51/books?offset=0&limit=50") },
new LinkObject { Id = 111, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/51?offset=0&limit=50") },
new LinkObject { Id = 112, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/52") },
new LinkObject { Id = 113, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/52/books?offset=0&limit=50") },
new LinkObject { Id = 114, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/52?offset=0&limit=50") },
new LinkObject { Id = 115, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/53") },
new LinkObject { Id = 116, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/53/books?offset=0&limit=50") },
new LinkObject { Id = 117, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/53?offset=0&limit=50") },
new LinkObject { Id = 118, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/20") },
new LinkObject { Id = 119, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/20/books?offset=0&limit=50") },
new LinkObject { Id = 120, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/20?offset=0&limit=50") },
new LinkObject { Id = 121, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/162") },
new LinkObject { Id = 122, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/162/books?offset=0&limit=50") },
new LinkObject { Id = 123, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/162?offset=0&limit=50") },
new LinkObject { Id = 124, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/22") },
new LinkObject { Id = 125, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/22/books?offset=0&limit=50") },
new LinkObject { Id = 126, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/22?offset=0&limit=50") },
new LinkObject { Id = 127, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/23") },
new LinkObject { Id = 128, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/23/books?offset=0&limit=50") },
new LinkObject { Id = 129, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/23?offset=0&limit=50") },
new LinkObject { Id = 130, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/84") },
new LinkObject { Id = 131, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/84/books?offset=0&limit=50") },
new LinkObject { Id = 132, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/84?offset=0&limit=50") },
new LinkObject { Id = 133, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/85") },
new LinkObject { Id = 134, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/85/books?offset=0&limit=50") },
new LinkObject { Id = 135, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/85?offset=0&limit=50") },
new LinkObject { Id = 136, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/86") },
new LinkObject { Id = 137, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/86/books?offset=0&limit=50") },
new LinkObject { Id = 138, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/86?offset=0&limit=50") },
new LinkObject { Id = 139, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/87") },
new LinkObject { Id = 140, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/87/books?offset=0&limit=50") },
new LinkObject { Id = 141, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/87?offset=0&limit=50") },
new LinkObject { Id = 142, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/88") },
new LinkObject { Id = 143, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/88/books?offset=0&limit=50") },
new LinkObject { Id = 144, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/88?offset=0&limit=50") },
new LinkObject { Id = 145, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/89") },
new LinkObject { Id = 146, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/89/books?offset=0&limit=50") },
new LinkObject { Id = 147, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/89?offset=0&limit=50") },
new LinkObject { Id = 148, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/90") },
new LinkObject { Id = 149, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/90/books?offset=0&limit=50") },
new LinkObject { Id = 150, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/90?offset=0&limit=50") },
new LinkObject { Id = 151, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/91") },
new LinkObject { Id = 152, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/91/books?offset=0&limit=50") },
new LinkObject { Id = 153, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/91?offset=0&limit=50") },
new LinkObject { Id = 154, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/92") },
new LinkObject { Id = 155, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/92/books?offset=0&limit=50") },
new LinkObject { Id = 156, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/92?offset=0&limit=50") },
new LinkObject { Id = 157, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/93") },
new LinkObject { Id = 158, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/93/books?offset=0&limit=50") },
new LinkObject { Id = 159, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/93?offset=0&limit=50") },
new LinkObject { Id = 160, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/94") },
new LinkObject { Id = 161, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/94/books?offset=0&limit=50") },
new LinkObject { Id = 162, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/94?offset=0&limit=50") },
new LinkObject { Id = 163, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/95") },
new LinkObject { Id = 164, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/95/books?offset=0&limit=50") },
new LinkObject { Id = 165, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/95?offset=0&limit=50") },
new LinkObject { Id = 166, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/96") },
new LinkObject { Id = 167, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/96/books?offset=0&limit=50") },
new LinkObject { Id = 168, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/96?offset=0&limit=50") },
new LinkObject { Id = 169, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/97") },
new LinkObject { Id = 170, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/97/books?offset=0&limit=50") },
new LinkObject { Id = 171, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/97?offset=0&limit=50") },
new LinkObject { Id = 172, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/38") },
new LinkObject { Id = 173, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/38/books?offset=0&limit=50") },
new LinkObject { Id = 174, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/38?offset=0&limit=50") },
new LinkObject { Id = 175, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/41") },
new LinkObject { Id = 176, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/41/books?offset=0&limit=50") },
new LinkObject { Id = 177, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/41?offset=0&limit=50") },
new LinkObject { Id = 178, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/43") },
new LinkObject { Id = 179, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/43/books?offset=0&limit=50") },
new LinkObject { Id = 180, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/43?offset=0&limit=50") },
new LinkObject { Id = 181, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/45") },
new LinkObject { Id = 182, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/45/books?offset=0&limit=50") },
new LinkObject { Id = 183, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/45?offset=0&limit=50") },
new LinkObject { Id = 184, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/47") },
new LinkObject { Id = 185, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/47/books?offset=0&limit=50") },
new LinkObject { Id = 186, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/47?offset=0&limit=50") },
new LinkObject { Id = 187, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/98") },
new LinkObject { Id = 188, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/98/books?offset=0&limit=50") },
new LinkObject { Id = 189, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/98?offset=0&limit=50") },
new LinkObject { Id = 190, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/99") },
new LinkObject { Id = 191, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/99/books?offset=0&limit=50") },
new LinkObject { Id = 192, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/99?offset=0&limit=50") },
new LinkObject { Id = 193, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/100") },
new LinkObject { Id = 194, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/100/books?offset=0&limit=50") },
new LinkObject { Id = 195, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/100?offset=0&limit=50") },
new LinkObject { Id = 196, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/101") },
new LinkObject { Id = 197, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/101/books?offset=0&limit=50") },
new LinkObject { Id = 198, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/101?offset=0&limit=50") },
new LinkObject { Id = 199, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/102") },
new LinkObject { Id = 200, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/102/books?offset=0&limit=50") },
new LinkObject { Id = 201, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/102?offset=0&limit=50") },
new LinkObject { Id = 202, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/103") },
new LinkObject { Id = 203, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/103/books?offset=0&limit=50") },
new LinkObject { Id = 204, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/103?offset=0&limit=50") },
new LinkObject { Id = 205, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/105") },
new LinkObject { Id = 206, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/105/books?offset=0&limit=50") },
new LinkObject { Id = 207, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/105?offset=0&limit=50") },
new LinkObject { Id = 208, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/34") },
new LinkObject { Id = 209, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/34/books?offset=0&limit=50") },
new LinkObject { Id = 210, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/34?offset=0&limit=50") },
new LinkObject { Id = 211, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/36") },
new LinkObject { Id = 212, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/36/books?offset=0&limit=50") },
new LinkObject { Id = 213, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/36?offset=0&limit=50") },
new LinkObject { Id = 214, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/37") },
new LinkObject { Id = 215, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/37/books?offset=0&limit=50") },
new LinkObject { Id = 216, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/37?offset=0&limit=50") },
new LinkObject { Id = 217, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/73") },
new LinkObject { Id = 218, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/73/books?offset=0&limit=50") },
new LinkObject { Id = 219, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/73?offset=0&limit=50") },
new LinkObject { Id = 220, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/24") },
new LinkObject { Id = 221, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/24/books?offset=0&limit=50") },
new LinkObject { Id = 222, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/24?offset=0&limit=50") },
new LinkObject { Id = 223, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/155") },
new LinkObject { Id = 224, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/155/books?offset=0&limit=50") },
new LinkObject { Id = 225, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/155?offset=0&limit=50") },
new LinkObject { Id = 226, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/156") },
new LinkObject { Id = 227, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/156/books?offset=0&limit=50") },
new LinkObject { Id = 228, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/156?offset=0&limit=50") },
new LinkObject { Id = 229, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/157") },
new LinkObject { Id = 230, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/157/books?offset=0&limit=50") },
new LinkObject { Id = 231, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/157?offset=0&limit=50") },
new LinkObject { Id = 232, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/158") },
new LinkObject { Id = 233, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/158/books?offset=0&limit=50") },
new LinkObject { Id = 234, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/158?offset=0&limit=50") },
new LinkObject { Id = 235, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/159") },
new LinkObject { Id = 236, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/159/books?offset=0&limit=50") },
new LinkObject { Id = 237, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/159?offset=0&limit=50") },
new LinkObject { Id = 238, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/112") },
new LinkObject { Id = 239, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/112/books?offset=0&limit=50") },
new LinkObject { Id = 240, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/112?offset=0&limit=50") },
new LinkObject { Id = 241, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/113") },
new LinkObject { Id = 242, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/113/books?offset=0&limit=50") },
new LinkObject { Id = 243, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/113?offset=0&limit=50") },
new LinkObject { Id = 244, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/114") },
new LinkObject { Id = 245, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/114/books?offset=0&limit=50") },
new LinkObject { Id = 246, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/114?offset=0&limit=50") },
new LinkObject { Id = 247, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/115") },
new LinkObject { Id = 248, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/115/books?offset=0&limit=50") },
new LinkObject { Id = 249, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/115?offset=0&limit=50") },
new LinkObject { Id = 250, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/116") },
new LinkObject { Id = 251, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/116/books?offset=0&limit=50") },
new LinkObject { Id = 252, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/116?offset=0&limit=50") },
new LinkObject { Id = 253, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/117") },
new LinkObject { Id = 254, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/117/books?offset=0&limit=50") },
new LinkObject { Id = 255, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/117?offset=0&limit=50") },
new LinkObject { Id = 256, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/118") },
new LinkObject { Id = 257, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/118/books?offset=0&limit=50") },
new LinkObject { Id = 258, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/118?offset=0&limit=50") },
new LinkObject { Id = 259, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/119") },
new LinkObject { Id = 260, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/119/books?offset=0&limit=50") },
new LinkObject { Id = 261, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/119?offset=0&limit=50") },
new LinkObject { Id = 262, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/120") },
new LinkObject { Id = 263, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/120/books?offset=0&limit=50") },
new LinkObject { Id = 264, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/120?offset=0&limit=50") },
new LinkObject { Id = 265, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/121") },
new LinkObject { Id = 266, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/121/books?offset=0&limit=50") },
new LinkObject { Id = 267, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/121?offset=0&limit=50") },
new LinkObject { Id = 268, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/122") },
new LinkObject { Id = 269, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/122/books?offset=0&limit=50") },
new LinkObject { Id = 270, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/122?offset=0&limit=50") },
new LinkObject { Id = 271, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/123") },
new LinkObject { Id = 272, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/123/books?offset=0&limit=50") },
new LinkObject { Id = 273, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/123?offset=0&limit=50") },
new LinkObject { Id = 274, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/124") },
new LinkObject { Id = 275, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/124/books?offset=0&limit=50") },
new LinkObject { Id = 276, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/124?offset=0&limit=50") },
new LinkObject { Id = 277, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/125") },
new LinkObject { Id = 278, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/125/books?offset=0&limit=50") },
new LinkObject { Id = 279, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/125?offset=0&limit=50") },
new LinkObject { Id = 280, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/126") },
new LinkObject { Id = 281, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/126/books?offset=0&limit=50") },
new LinkObject { Id = 282, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/126?offset=0&limit=50") },
new LinkObject { Id = 283, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/127") },
new LinkObject { Id = 284, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/127/books?offset=0&limit=50") },
new LinkObject { Id = 285, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/127?offset=0&limit=50") },
new LinkObject { Id = 286, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/128") },
new LinkObject { Id = 287, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/128/books?offset=0&limit=50") },
new LinkObject { Id = 288, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/128?offset=0&limit=50") },
new LinkObject { Id = 289, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/129") },
new LinkObject { Id = 290, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/129/books?offset=0&limit=50") },
new LinkObject { Id = 291, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/129?offset=0&limit=50") },
new LinkObject { Id = 292, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/130") },
new LinkObject { Id = 293, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/130/books?offset=0&limit=50") },
new LinkObject { Id = 294, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/130?offset=0&limit=50") },
new LinkObject { Id = 295, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/131") },
new LinkObject { Id = 296, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/131/books?offset=0&limit=50") },
new LinkObject { Id = 297, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/131?offset=0&limit=50") },
new LinkObject { Id = 298, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/132") },
new LinkObject { Id = 299, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/132/books?offset=0&limit=50") },
new LinkObject { Id = 300, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/132?offset=0&limit=50") },
new LinkObject { Id = 301, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/133") },
new LinkObject { Id = 302, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/133/books?offset=0&limit=50") },
new LinkObject { Id = 303, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/133?offset=0&limit=50") },
new LinkObject { Id = 304, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/134") },
new LinkObject { Id = 305, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/134/books?offset=0&limit=50") },
new LinkObject { Id = 306, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/134?offset=0&limit=50") },
new LinkObject { Id = 307, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/135") },
new LinkObject { Id = 308, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/135/books?offset=0&limit=50") },
new LinkObject { Id = 309, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/135?offset=0&limit=50") },
new LinkObject { Id = 310, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/136") },
new LinkObject { Id = 311, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/136/books?offset=0&limit=50") },
new LinkObject { Id = 312, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/136?offset=0&limit=50") },
new LinkObject { Id = 313, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/137") },
new LinkObject { Id = 314, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/137/books?offset=0&limit=50") },
new LinkObject { Id = 315, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/137?offset=0&limit=50") },
new LinkObject { Id = 316, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/138") },
new LinkObject { Id = 317, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/138/books?offset=0&limit=50") },
new LinkObject { Id = 318, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/138?offset=0&limit=50") },
new LinkObject { Id = 319, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/139") },
new LinkObject { Id = 320, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/139/books?offset=0&limit=50") },
new LinkObject { Id = 321, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/139?offset=0&limit=50") },
new LinkObject { Id = 322, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/140") },
new LinkObject { Id = 323, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/140/books?offset=0&limit=50") },
new LinkObject { Id = 324, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/140?offset=0&limit=50") },
new LinkObject { Id = 325, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/141") },
new LinkObject { Id = 326, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/141/books?offset=0&limit=50") },
new LinkObject { Id = 327, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/141?offset=0&limit=50") },
new LinkObject { Id = 328, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/142") },
new LinkObject { Id = 329, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/142/books?offset=0&limit=50") },
new LinkObject { Id = 330, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/142?offset=0&limit=50") },
new LinkObject { Id = 331, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/143") },
new LinkObject { Id = 332, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/143/books?offset=0&limit=50") },
new LinkObject { Id = 333, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/143?offset=0&limit=50") },
new LinkObject { Id = 334, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/144") },
new LinkObject { Id = 335, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/144/books?offset=0&limit=50") },
new LinkObject { Id = 336, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/144?offset=0&limit=50") },
new LinkObject { Id = 337, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/145") },
new LinkObject { Id = 338, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/145/books?offset=0&limit=50") },
new LinkObject { Id = 339, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/145?offset=0&limit=50") },
new LinkObject { Id = 340, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/146") },
new LinkObject { Id = 341, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/146/books?offset=0&limit=50") },
new LinkObject { Id = 342, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/146?offset=0&limit=50") },
new LinkObject { Id = 343, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/147") },
new LinkObject { Id = 344, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/147/books?offset=0&limit=50") },
new LinkObject { Id = 345, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/147?offset=0&limit=50") },
new LinkObject { Id = 346, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/148") },
new LinkObject { Id = 347, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/148/books?offset=0&limit=50") },
new LinkObject { Id = 348, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/148?offset=0&limit=50") },
new LinkObject { Id = 349, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/149") },
new LinkObject { Id = 350, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/149/books?offset=0&limit=50") },
new LinkObject { Id = 351, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/149?offset=0&limit=50") },
new LinkObject { Id = 352, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/150") },
new LinkObject { Id = 353, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/150/books?offset=0&limit=50") },
new LinkObject { Id = 354, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/150?offset=0&limit=50") },
new LinkObject { Id = 355, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/151") },
new LinkObject { Id = 356, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/151/books?offset=0&limit=50") },
new LinkObject { Id = 357, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/151?offset=0&limit=50") },
new LinkObject { Id = 358, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/152") },
new LinkObject { Id = 359, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/152/books?offset=0&limit=50") },
new LinkObject { Id = 360, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/152?offset=0&limit=50") },
new LinkObject { Id = 361, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/153") },
new LinkObject { Id = 362, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/153/books?offset=0&limit=50") },
new LinkObject { Id = 363, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/153?offset=0&limit=50") },
new LinkObject { Id = 364, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/165") },
new LinkObject { Id = 365, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/165/books?offset=0&limit=50") },
new LinkObject { Id = 366, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/165?offset=0&limit=50") },
new LinkObject { Id = 367, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/167") },
new LinkObject { Id = 368, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/167/books?offset=0&limit=50") },
new LinkObject { Id = 369, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/167?offset=0&limit=50") },
new LinkObject { Id = 370, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/168") },
new LinkObject { Id = 371, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/168/books?offset=0&limit=50") },
new LinkObject { Id = 372, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/168?offset=0&limit=50") },
new LinkObject { Id = 373, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/170") },
new LinkObject { Id = 374, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/170/books?offset=0&limit=50") },
new LinkObject { Id = 375, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/170?offset=0&limit=50") },
new LinkObject { Id = 376, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/171") },
new LinkObject { Id = 377, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/171/books?offset=0&limit=50") },
new LinkObject { Id = 378, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/171?offset=0&limit=50") },
new LinkObject { Id = 379, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/166") },
new LinkObject { Id = 380, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/166/books?offset=0&limit=50") },
new LinkObject { Id = 381, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/166?offset=0&limit=50") },
new LinkObject { Id = 382, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/172") },
new LinkObject { Id = 383, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/172/books?offset=0&limit=50") },
new LinkObject { Id = 384, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/172?offset=0&limit=50") },
new LinkObject { Id = 385, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/173") },
new LinkObject { Id = 386, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/173/books?offset=0&limit=50") },
new LinkObject { Id = 387, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/173?offset=0&limit=50") },
new LinkObject { Id = 388, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/174") },
new LinkObject { Id = 389, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/174/books?offset=0&limit=50") },
new LinkObject { Id = 390, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/174?offset=0&limit=50") },
new LinkObject { Id = 391, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/175") },
new LinkObject { Id = 392, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/175/books?offset=0&limit=50") },
new LinkObject { Id = 393, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/175?offset=0&limit=50") },
new LinkObject { Id = 394, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/176") },
new LinkObject { Id = 395, Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/176/books?offset=0&limit=50") },
new LinkObject { Id = 396, Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/176?offset=0&limit=50") }
        );
       



        modelBuilder.Entity<Category>(e => {
            e.HasOne(e => e.Links).WithOne(c => c.Category).HasForeignKey<Links>(x => x.CategoryId);
            e.HasMany(c => c.Children).WithOne(c => c.Parent).HasForeignKey(x => x.ParentId);
            e.HasData(
new Category { Id = 12, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_12.png?format=png&quality=75&w=450"), Title = "Crime, Thrillers & Mystery"},
new Category { Id = 2, Image =   new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_2.png?format=png&quality=75&w=450"), Title = "Novels" },
new Category { Id = 54, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_54.png?format=png&quality=75&w=450"), Title = "Non-Fiction Books" },
new Category { Id = 27, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_27.png?format=png&quality=75&w=450"), Title = "Romance" },
new Category { Id = 48, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_48.png?format=png&quality=75&w=450"), Title = "Biographies" },
new Category { Id = 20, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_20.png?format=png&quality=75&w=450"), Title = "Fantasy" },
new Category { Id = 84, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_84.png?format=png&quality=75&w=450"), Title = "Books for Children" },
new Category { Id = 38, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_38.png?format=png&quality=75&w=450"), Title = "Personal Development" },
new Category { Id = 98, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_98.png?format=png&quality=75&w=450"), Title = "Books for Young Adults" },
new Category { Id = 34, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_34.png?format=png&quality=75&w=450"), Title = "Comedy & Humour" },
new Category { Id = 73, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_73.png?format=png&quality=75&w=450"), Title = "Classics" },
new Category { Id = 24, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_24.png?format=png&quality=75&w=450"), Title = "Science Fiction" },
new Category { Id = 155, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_155.png?format=png&quality=75&w=450"), Title = "Short Stories, Drama & Poetry" },
new Category { Id = 112, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_112.jpg?format=png&quality=75&w=450"), Title = "Svenska" },
new Category { Id = 118, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_118.jpg?format=png&quality=75&w=450"), Title = "Suomi" },
new Category { Id = 124, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_124.jpg?format=png&quality=75&w=450"), Title = "Deutsch" },
new Category { Id = 130, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_130.jpg?format=png&quality=75&w=450"), Title = "Italiano" },
new Category { Id = 136, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_136.jpg?format=png&quality=75&w=450"), Title = "Español" },
new Category { Id = 142, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_142.jpg?format=png&quality=75&w=450"), Title = "Dansk" },
new Category { Id = 148, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_148.jpg?format=png&quality=75&w=450"), Title = "Polski" },
new Category { Id = 165, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_165.jpg?format=png&quality=75&w=450"), Title = "Nederlands" },
new Category { Id = 166, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_166.jpg?format=png&quality=75&w=450"), Title = "Français" },

new Category { ParentId = 12, Id = 13, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_14.png?format=png&quality=75&w=450"), Title = "Thrillers" },
new Category { ParentId = 12, Id = 14, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_81.png?format=png&quality=75&w=450"), Title = "Psychological Thrillers" },
new Category { ParentId = 12, Id = 15, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_9.png?format=png&quality=75&w=450"), Title = "Crime Fiction" },  
new Category { ParentId = 12, Id = 16, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_13.png?format=png&quality=75&w=450"), Title = "Classic Crime & Mystery Fiction" },
new Category { ParentId = 12, Id = 17, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_11.png?format=png&quality=75&w=450"), Title = "Cosy Crime" },

new Category { ParentId = 2, Id = 5, Image =   new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_899.png?format=png&quality=75&w=450"), Title = "Historical Novels" },
new Category { ParentId = 2, Id = 6, Image =   new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_4.png?format=png&quality=75&w=450"), Title = "Feel-Good Novels" },
new Category { ParentId = 2, Id = 8, Image =   new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_85.png?format=png&quality=75&w=450"), Title = "Contemporary Novels" },
new Category { ParentId = 2, Id = 11, Image =  new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_25.png?format=png&quality=75&w=450"), Title = "War Novels" },
new Category { ParentId = 2, Id = 177, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_177.jpg?format=png&quality=75&w=450"), Title = "Family Sagas" },

new Category { ParentId = 54, Id = 160, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_79.png?format=png&quality=75&w=450"), Title = "Food & Drink" },
new Category { ParentId = 54, Id = 161, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_53.png?format=png&quality=75&w=450"), Title = "Leisure & Hobbies" },
new Category { ParentId = 54, Id = 55, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_82.png?format=png&quality=75&w=450"), Title = "True Crime" },
new Category { ParentId = 54, Id = 56, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_31.png?format=png&quality=75&w=450"), Title = "Music & Films" },
new Category { ParentId = 54, Id = 57, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_83.png?format=png&quality=75&w=450"), Title = "Literature & Art" },
new Category { ParentId = 54, Id = 58, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_77.png?format=png&quality=75&w=450"), Title = "Language & Linguistics" },
new Category { ParentId = 54, Id = 59, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_24.png?format=png&quality=75&w=450"), Title = "Law" },
new Category { ParentId = 54, Id = 60, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_87.png?format=png&quality=75&w=450"), Title = "Society & Culture" },
new Category { ParentId = 54, Id = 61, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_94.png?format=png&quality=75&w=450"), Title = "Psychology" },
new Category { ParentId = 54, Id = 62, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_844.png?format=png&quality=75&w=450"), Title = "Politics & War" },
new Category { ParentId = 54, Id = 63, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_91.png?format=png&quality=75&w=450"), Title = "Travelling & Countries" },
new Category { ParentId = 54, Id = 64, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_26.png?format=png&quality=75&w=450"), Title = "History" },
new Category { ParentId = 54, Id = 65, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_20.png?format=png&quality=75&w=450"), Title = "Sports" },
new Category { ParentId = 54, Id = 66, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_211.png?format=png&quality=75&w=450"), Title = "Nature & Science" },
new Category { ParentId = 54, Id = 67, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_35.png?format=png&quality=75&w=450"), Title = "Economics & Finance" },
new Category { ParentId = 54, Id = 68, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_48.png?format=png&quality=75&w=450"), Title = "Religion & Philosophy" },

new Category { ParentId = 27, Id = 30, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_99.png?format=png&quality=75&w=450"), Title = "Hot Romance" },
new Category { ParentId = 27, Id = 32, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_98.png?format=png&quality=75&w=450"), Title = "Romantic Suspense" },
new Category { ParentId = 27, Id = 33, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_988.png?format=png&quality=75&w=450"), Title = "Historical Romance" },

new Category { ParentId = 48, Id = 49, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_73.png?format=png&quality=75&w=450"), Title = "Autobiographies & Memoirs" },
new Category { ParentId = 48, Id = 50, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_34.png?format=png&quality=75&w=450"), Title = "Political & Societal Biographies" },
new Category { ParentId = 48, Id = 51, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_322.png?format=png&quality=75&w=450"), Title = "Royal Biographies" },
new Category { ParentId = 48, Id = 52, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_45.png?format=png&quality=75&w=450"), Title = "Art & Literary Biographies" },
new Category { ParentId = 48, Id = 53, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_78.png?format=png&quality=75&w=450"), Title = "Religious & Philosofical Biographie" },

new Category { ParentId = 20, Id = 162, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_162.png?format=png&quality=75&w=450"), Title = "High Fantasy" },
new Category { ParentId = 20, Id = 22, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_32.png?format=png&quality=75&w=450"), Title = "Romantic Fantasy" },
new Category { ParentId = 20, Id = 23, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_41.png?format=png&quality=75&w=450"), Title = "Horror" },

new Category { ParentId = 84, Id = 85, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_55.png?format=png&quality=75&w=450"), Title = "Books for Children: 0-36 months" },
new Category { ParentId = 84, Id = 86, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_56.png?format=png&quality=75&w=450"), Title = "Books for Children: from 3 years" },
new Category { ParentId = 84, Id = 87, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_54.png?format=png&quality=75&w=450"), Title = "Books for Children: from 6 years" },
new Category { ParentId = 84, Id = 88, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_60.png?format=png&quality=75&w=450"), Title = "Books for Children: from 9 years" },
new Category { ParentId = 84, Id = 89, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_544.png?format=png&quality=75&w=450"), Title = "Classic Books for Children" },
new Category { ParentId = 84, Id = 90, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_50.png?format=png&quality=75&w=450"), Title = "Non-Fiction Books for Children" },
new Category { ParentId = 84, Id = 91, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_58.png?format=png&quality=75&w=450"), Title = "Fairy Tales for Children" },
new Category { ParentId = 84, Id = 92, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_57.png?format=png&quality=75&w=450"), Title = "Animal & Nature Stories for Children" },
new Category { ParentId = 84, Id = 93, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_200.png?format=png&quality=75&w=450"), Title = "Sporting Stories for Children" },
new Category { ParentId = 84, Id = 94, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_37.png?format=png&quality=75&w=450"), Title = "Adventure Stories for Children" },
new Category { ParentId = 84, Id = 95, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_533.png?format=png&quality=75&w=450"), Title = "Fun for kids" },
new Category { ParentId = 84, Id = 96, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_61.png?format=png&quality=75&w=450"), Title = "Ghosts & Supernatural for Children" },
new Category { ParentId = 84, Id = 97, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_59.png?format=png&quality=75&w=450"), Title = "Love & Friendship for Children" },

new Category { ParentId = 38, Id = 41, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_51.png?format=png&quality=75&w=450"), Title = "Relationships & Families" },
new Category { ParentId = 38, Id = 43, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_94.png?format=png&quality=75&w=450"), Title = "Popular Psychology" },
new Category { ParentId = 38, Id = 45, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_96.png?format=png&quality=75&w=450"), Title = "Health & Fitness" },
new Category { ParentId = 38, Id = 47, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_95.png?format=png&quality=75&w=450"), Title = "Mindfulness & Spirituality" },

new Category { ParentId = 98, Id = 99, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_599.png?format=png&quality=75&w=450"), Title = "Books for Young Adults: from 12 years" },
new Category { ParentId = 98, Id = 100, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_63.png?format=png&quality=75&w=450"), Title = "Books for Young Adults: from 14 years" },
new Category { ParentId = 98, Id = 101, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_2.png?format=png&quality=75&w=450"), Title = "Young love" },
new Category { ParentId = 98, Id = 102, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Crime Books for Young Adults" },
new Category { ParentId = 98, Id = 103, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_899.png?format=png&quality=75&w=450"), Title = "Historical Novels for Young Adults" },
new Category { ParentId = 98, Id = 105, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasy & Science Fiction for Young Adults" },

new Category { ParentId = 34, Id = 36, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_72.png?format=png&quality=75&w=450"), Title = "Humoristic Novels" },
new Category { ParentId = 34, Id = 37, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_10.png?format=png&quality=75&w=450"), Title = "Parody & Satire" },


new Category { ParentId = 155, Id = 156, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_156.png?format=png&quality=75&w=450"), Title = "Short Stories" },
new Category { ParentId = 155, Id = 157, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_157.png?format=png&quality=75&w=450"), Title = "Comics & Graphic Novels" },
new Category { ParentId = 155, Id = 158, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_158.png?format=png&quality=75&w=450"), Title = "Plays & Playscripts" },
new Category { ParentId = 155, Id = 159, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_159.png?format=png&quality=75&w=450"), Title = "Poetry" },

new Category { ParentId = 112, Id = 113, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Romaner" },
new Category { ParentId = 112, Id = 114, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Spänning" },
new Category { ParentId = 112, Id = 115, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasy & Science Fiction" },
new Category { ParentId = 112, Id = 116, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Fakta" },
new Category { ParentId = 112, Id = 117, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Barn & Ungdom" },

new Category { ParentId = 118, Id = 119, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Romaanit" },
new Category { ParentId = 118, Id = 120, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Dekkarit" },
new Category { ParentId = 118, Id = 121, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasia & Science Fiction" },
new Category { ParentId = 118, Id = 122, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Tieto" },
new Category { ParentId = 118, Id = 123, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Lapset & Nuoret" },

new Category { ParentId = 124, Id = 125, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Romane" },
new Category { ParentId = 124, Id = 126, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Spannung" },
new Category { ParentId = 124, Id = 127, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasy & Science Fiction" },
new Category { ParentId = 124, Id = 128, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Sachbuch" },
new Category { ParentId = 124, Id = 129, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Kinder & Jugendbuch" },

new Category { ParentId = 130, Id = 131, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Narrativa" },
new Category { ParentId = 130, Id = 132, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Thriller" },
new Category { ParentId = 130, Id = 133, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasy e fantascienza" },
new Category { ParentId = 130, Id = 134, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Non-fiction" },
new Category { ParentId = 130, Id = 135, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Bambini" },

new Category { ParentId = 136, Id = 137, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Ficción" },
new Category { ParentId = 136,  Id = 138, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Negra y criminal" },
new Category { ParentId = 136,  Id = 139, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Narrativa fantástica y novela de ciencia ficción" },
new Category { ParentId = 136,  Id = 140, Image =new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "No ficción" },
new Category { ParentId = 136, Id = 141, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Infantil y juvenil" },

new Category { ParentId = 142, Id = 143, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Skønlitteratur" },
new Category { ParentId = 142, Id = 144, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Krimi & Spænding" },
new Category { ParentId = 142, Id = 145, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Sci-fi & Fantasy" },
new Category { ParentId = 142, Id = 146, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Faglitteratur & Personlig udvikling" },
new Category { ParentId = 142, Id = 147, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Børnebøger & Ungdom/YA" },

new Category { ParentId = 148, Id = 149, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Powieści" },
new Category { ParentId = 148, Id = 150, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Kryminały" },
new Category { ParentId = 148, Id = 151, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantastyka i Sci-fi" },
new Category { ParentId = 148, Id = 152, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Literatura faktu" },
new Category { ParentId = 148, Id = 153, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Dla dzieci i młodzieży" },

new Category { ParentId = 165, Id = 167, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Romans" },
new Category { ParentId = 165, Id = 168, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Misdaad" },
new Category { ParentId = 165, Id = 169, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasy & Sciencefiction" },
new Category { ParentId = 165, Id = 170, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Non-fictie" },
new Category { ParentId = 165, Id = 171, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Kinderboeken & Young Adult" },

new Category { ParentId = 166, Id = 172, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_8.png?format=png&quality=75&w=450"), Title = "Crime" },
new Category { ParentId = 166, Id = 173, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_1.png?format=png&quality=75&w=450"), Title = "Romans" },
new Category { ParentId = 166, Id = 174, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_69.png?format=png&quality=75&w=450"), Title = "Non-fiction" },
new Category { ParentId = 166, Id = 175, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_36.png?format=png&quality=75&w=450"), Title = "Fantasy & Science fiction" },
new Category { ParentId = 166, Id = 176, Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_52.png?format=png&quality=75&w=450"), Title = "Enfants & Young Adult" });        
        });

        
        modelBuilder.Entity<Links>(e => {
            e.HasOne(p => p.Self).WithMany().HasForeignKey(x => x.SelfId);
            e.HasOne(p => p.Books).WithMany().HasForeignKey(x => x.BooksId);
            e.HasOne(p => p.DynamicContent).WithMany().HasForeignKey(x => x.DynamicContentId);
            e.HasData(new Links{Id = 1, SelfId = 1, BooksId = 2, DynamicContentId = 3, CategoryId = 12},
new Links{Id = 2, SelfId = 4, BooksId = 5, DynamicContentId = 6, CategoryId = 13},
new Links{Id = 3, SelfId = 7, BooksId = 8, DynamicContentId = 9, CategoryId = 14},
new Links{Id = 4, SelfId = 10, BooksId = 11, DynamicContentId = 12, CategoryId = 15},
new Links{Id = 5, SelfId = 13, BooksId = 14, DynamicContentId = 15, CategoryId = 16},
new Links{Id = 6, SelfId = 16, BooksId = 17, DynamicContentId = 18, CategoryId = 17},
new Links{Id = 7, SelfId = 19, BooksId = 20, DynamicContentId = 21, CategoryId = 2},
new Links{Id = 8, SelfId = 22, BooksId = 23, DynamicContentId = 24, CategoryId = 5},
new Links{Id = 9, SelfId = 25, BooksId = 26, DynamicContentId = 27, CategoryId = 6},
new Links{Id = 10, SelfId = 28, BooksId = 29, DynamicContentId = 30, CategoryId = 8},
new Links{Id = 11, SelfId = 31, BooksId = 32, DynamicContentId = 33, CategoryId = 11},
new Links{Id = 12, SelfId = 34, BooksId = 35, DynamicContentId = 36, CategoryId = 177},
new Links{Id = 13, SelfId = 37, BooksId = 38, DynamicContentId = 39, CategoryId = 54},
new Links{Id = 14, SelfId = 40, BooksId = 41, DynamicContentId = 42, CategoryId = 160},
new Links{Id = 15, SelfId = 43, BooksId = 44, DynamicContentId = 45, CategoryId = 161},
new Links{Id = 16, SelfId = 46, BooksId = 47, DynamicContentId = 48, CategoryId = 55},
new Links{Id = 17, SelfId = 49, BooksId = 50, DynamicContentId = 51, CategoryId = 56},
new Links{Id = 18, SelfId = 52, BooksId = 53, DynamicContentId = 54, CategoryId = 57},
new Links{Id = 19, SelfId = 55, BooksId = 56, DynamicContentId = 57, CategoryId = 58},
new Links{Id = 20, SelfId = 58, BooksId = 59, DynamicContentId = 60, CategoryId = 59},
new Links{Id = 21, SelfId = 61, BooksId = 62, DynamicContentId = 63, CategoryId = 60},
new Links{Id = 22, SelfId = 64, BooksId = 65, DynamicContentId = 66, CategoryId = 61},
new Links{Id = 23, SelfId = 67, BooksId = 68, DynamicContentId = 69, CategoryId = 62},
new Links{Id = 24, SelfId = 70, BooksId = 71, DynamicContentId = 72, CategoryId = 63},
new Links{Id = 25, SelfId = 73, BooksId = 74, DynamicContentId = 75, CategoryId = 64},
new Links{Id = 26, SelfId = 76, BooksId = 77, DynamicContentId = 78, CategoryId = 65},
new Links{Id = 27, SelfId = 79, BooksId = 80, DynamicContentId = 81, CategoryId = 66},
new Links{Id = 28, SelfId = 82, BooksId = 83, DynamicContentId = 84, CategoryId = 67},
new Links{Id = 29, SelfId = 85, BooksId = 86, DynamicContentId = 87, CategoryId = 68},
new Links{Id = 30, SelfId = 88, BooksId = 89, DynamicContentId = 90, CategoryId = 27},
new Links{Id = 31, SelfId = 91, BooksId = 92, DynamicContentId = 93, CategoryId = 30},
new Links{Id = 32, SelfId = 94, BooksId = 95, DynamicContentId = 96, CategoryId = 32},
new Links{Id = 33, SelfId = 97, BooksId = 98, DynamicContentId = 99, CategoryId = 33},
new Links{Id = 34, SelfId = 100, BooksId = 101, DynamicContentId = 102, CategoryId = 48},
new Links{Id = 35, SelfId = 103, BooksId = 104, DynamicContentId = 105, CategoryId = 49},
new Links{Id = 36, SelfId = 106, BooksId = 107, DynamicContentId = 108, CategoryId = 50},
new Links{Id = 37, SelfId = 109, BooksId = 110, DynamicContentId = 111, CategoryId = 51},
new Links{Id = 38, SelfId = 112, BooksId = 113, DynamicContentId = 114, CategoryId = 52},
new Links{Id = 39, SelfId = 115, BooksId = 116, DynamicContentId = 117, CategoryId = 53},
new Links{Id = 40, SelfId = 118, BooksId = 119, DynamicContentId = 120, CategoryId = 20},
new Links{Id = 41, SelfId = 121, BooksId = 122, DynamicContentId = 123, CategoryId = 162},
new Links{Id = 42, SelfId = 124, BooksId = 125, DynamicContentId = 126, CategoryId = 22},
new Links{Id = 43, SelfId = 127, BooksId = 128, DynamicContentId = 129, CategoryId = 23},
new Links{Id = 44, SelfId = 130, BooksId = 131, DynamicContentId = 132, CategoryId = 84},
new Links{Id = 45, SelfId = 133, BooksId = 134, DynamicContentId = 135, CategoryId = 85},
new Links{Id = 46, SelfId = 136, BooksId = 137, DynamicContentId = 138, CategoryId = 86},
new Links{Id = 47, SelfId = 139, BooksId = 140, DynamicContentId = 141, CategoryId = 87},
new Links{Id = 48, SelfId = 142, BooksId = 143, DynamicContentId = 144, CategoryId = 88},
new Links{Id = 49, SelfId = 145, BooksId = 146, DynamicContentId = 147, CategoryId = 89},
new Links{Id = 50, SelfId = 148, BooksId = 149, DynamicContentId = 150, CategoryId = 90},
new Links{Id = 51, SelfId = 151, BooksId = 152, DynamicContentId = 153, CategoryId = 91},
new Links{Id = 52, SelfId = 154, BooksId = 155, DynamicContentId = 156, CategoryId = 92},
new Links{Id = 53, SelfId = 157, BooksId = 158, DynamicContentId = 159, CategoryId = 93},
new Links{Id = 54, SelfId = 160, BooksId = 161, DynamicContentId = 162, CategoryId = 94},
new Links{Id = 55, SelfId = 163, BooksId = 164, DynamicContentId = 165, CategoryId = 95},
new Links{Id = 56, SelfId = 166, BooksId = 167, DynamicContentId = 168, CategoryId = 96},
new Links{Id = 57, SelfId = 169, BooksId = 170, DynamicContentId = 171, CategoryId = 97},
new Links{Id = 58, SelfId = 172, BooksId = 173, DynamicContentId = 174, CategoryId = 38},
new Links{Id = 59, SelfId = 175, BooksId = 176, DynamicContentId = 177, CategoryId = 41},
new Links{Id = 60, SelfId = 178, BooksId = 179, DynamicContentId = 180, CategoryId = 43},
new Links{Id = 61, SelfId = 181, BooksId = 182, DynamicContentId = 183, CategoryId = 45},
new Links{Id = 62, SelfId = 184, BooksId = 185, DynamicContentId = 186, CategoryId = 47},
new Links{Id = 63, SelfId = 187, BooksId = 188, DynamicContentId = 189, CategoryId = 98},
new Links{Id = 64, SelfId = 190, BooksId = 191, DynamicContentId = 192, CategoryId = 99},
new Links{Id = 65, SelfId = 193, BooksId = 194, DynamicContentId = 195, CategoryId = 100},
new Links{Id = 66, SelfId = 196, BooksId = 197, DynamicContentId = 198, CategoryId = 101},
new Links{Id = 67, SelfId = 199, BooksId = 200, DynamicContentId = 201, CategoryId = 102},
new Links{Id = 68, SelfId = 202, BooksId = 203, DynamicContentId = 204, CategoryId = 103},
new Links{Id = 69, SelfId = 205, BooksId = 206, DynamicContentId = 207, CategoryId = 105},
new Links{Id = 70, SelfId = 208, BooksId = 209, DynamicContentId = 210, CategoryId = 34},
new Links{Id = 71, SelfId = 211, BooksId = 212, DynamicContentId = 213, CategoryId = 36},
new Links{Id = 72, SelfId = 214, BooksId = 215, DynamicContentId = 216, CategoryId = 37},
new Links{Id = 73, SelfId = 217, BooksId = 218, DynamicContentId = 219, CategoryId = 73},
new Links{Id = 74, SelfId = 220, BooksId = 221, DynamicContentId = 222, CategoryId = 24},
new Links{Id = 75, SelfId = 223, BooksId = 224, DynamicContentId = 225, CategoryId = 155},
new Links{Id = 76, SelfId = 226, BooksId = 227, DynamicContentId = 228, CategoryId = 156},
new Links{Id = 77, SelfId = 229, BooksId = 230, DynamicContentId = 231, CategoryId = 157},
new Links{Id = 78, SelfId = 232, BooksId = 233, DynamicContentId = 234, CategoryId = 158},
new Links{Id = 79, SelfId = 235, BooksId = 236, DynamicContentId = 237, CategoryId = 159},
new Links{Id = 80, SelfId = 238, BooksId = 239, DynamicContentId = 240, CategoryId = 112},
new Links{Id = 81, SelfId = 241, BooksId = 242, DynamicContentId = 243, CategoryId = 113},
new Links{Id = 82, SelfId = 244, BooksId = 245, DynamicContentId = 246, CategoryId = 114},
new Links{Id = 83, SelfId = 247, BooksId = 248, DynamicContentId = 249, CategoryId = 115},
new Links{Id = 84, SelfId = 250, BooksId = 251, DynamicContentId = 252, CategoryId = 116},
new Links{Id = 85, SelfId = 253, BooksId = 254, DynamicContentId = 255, CategoryId = 117},
new Links{Id = 86, SelfId = 256, BooksId = 257, DynamicContentId = 258, CategoryId = 118},
new Links{Id = 87, SelfId = 259, BooksId = 260, DynamicContentId = 261, CategoryId = 119},
new Links{Id = 88, SelfId = 262, BooksId = 263, DynamicContentId = 264, CategoryId = 120},
new Links{Id = 89, SelfId = 265, BooksId = 266, DynamicContentId = 267, CategoryId = 121},
new Links{Id = 90, SelfId = 268, BooksId = 269, DynamicContentId = 270, CategoryId = 122},
new Links{Id = 91, SelfId = 271, BooksId = 272, DynamicContentId = 273, CategoryId = 123},
new Links{Id = 92, SelfId = 274, BooksId = 275, DynamicContentId = 276, CategoryId = 124},
new Links{Id = 93, SelfId = 277, BooksId = 278, DynamicContentId = 279, CategoryId = 125},
new Links{Id = 94, SelfId = 280, BooksId = 281, DynamicContentId = 282, CategoryId = 126},
new Links{Id = 95, SelfId = 283, BooksId = 284, DynamicContentId = 285, CategoryId = 127},
new Links{Id = 96, SelfId = 286, BooksId = 287, DynamicContentId = 288, CategoryId = 128},
new Links{Id = 97, SelfId = 289, BooksId = 290, DynamicContentId = 291, CategoryId = 129},
new Links{Id = 98, SelfId = 292, BooksId = 293, DynamicContentId = 294, CategoryId = 130},
new Links{Id = 99, SelfId = 295, BooksId = 296, DynamicContentId = 297, CategoryId = 131},
new Links{Id = 100, SelfId = 298, BooksId = 299, DynamicContentId = 300, CategoryId = 132},
new Links{Id = 101, SelfId = 301, BooksId = 302, DynamicContentId = 303, CategoryId = 133},
new Links{Id = 102, SelfId = 304, BooksId = 305, DynamicContentId = 306, CategoryId = 134},
new Links{Id = 103, SelfId = 307, BooksId = 308, DynamicContentId = 309, CategoryId = 135},
new Links{Id = 104, SelfId = 310, BooksId = 311, DynamicContentId = 312, CategoryId = 136},
new Links{Id = 105, SelfId = 313, BooksId = 314, DynamicContentId = 315, CategoryId = 137},
new Links{Id = 106, SelfId = 316, BooksId = 317, DynamicContentId = 318, CategoryId = 138},
new Links{Id = 107, SelfId = 319, BooksId = 320, DynamicContentId = 321, CategoryId = 139},
new Links{Id = 108, SelfId = 322, BooksId = 323, DynamicContentId = 324, CategoryId = 140},
new Links{Id = 109, SelfId = 325, BooksId = 326, DynamicContentId = 327, CategoryId = 141},
new Links{Id = 110, SelfId = 328, BooksId = 329, DynamicContentId = 330, CategoryId = 142},
new Links{Id = 111, SelfId = 331, BooksId = 332, DynamicContentId = 333, CategoryId = 143},
new Links{Id = 112, SelfId = 334, BooksId = 335, DynamicContentId = 336, CategoryId = 144},
new Links{Id = 113, SelfId = 337, BooksId = 338, DynamicContentId = 339, CategoryId = 145},
new Links{Id = 114, SelfId = 340, BooksId = 341, DynamicContentId = 342, CategoryId = 146},
new Links{Id = 115, SelfId = 343, BooksId = 344, DynamicContentId = 345, CategoryId = 147},
new Links{Id = 116, SelfId = 346, BooksId = 347, DynamicContentId = 348, CategoryId = 148},
new Links{Id = 117, SelfId = 349, BooksId = 350, DynamicContentId = 351, CategoryId = 149},
new Links{Id = 118, SelfId = 352, BooksId = 353, DynamicContentId = 354, CategoryId = 150},
new Links{Id = 119, SelfId = 355, BooksId = 356, DynamicContentId = 357, CategoryId = 151},
new Links{Id = 120, SelfId = 358, BooksId = 359, DynamicContentId = 360, CategoryId = 152},
new Links{Id = 121, SelfId = 361, BooksId = 362, DynamicContentId = 363, CategoryId = 153},
new Links{Id = 122, SelfId = 364, BooksId = 365, DynamicContentId = 366, CategoryId = 165},
new Links{Id = 123, SelfId = 367, BooksId = 368, DynamicContentId = 369, CategoryId = 167},
new Links{Id = 124, SelfId = 370, BooksId = 371, DynamicContentId = 372, CategoryId = 168},
new Links{Id = 125, SelfId = 373, BooksId = 374, DynamicContentId = 375, CategoryId = 170},
new Links{Id = 126, SelfId = 376, BooksId = 377, DynamicContentId = 378, CategoryId = 171},
new Links{Id = 127, SelfId = 379, BooksId = 380, DynamicContentId = 381, CategoryId = 166},
new Links{Id = 128, SelfId = 382, BooksId = 383, DynamicContentId = 384, CategoryId = 172},
new Links{Id = 129, SelfId = 385, BooksId = 386, DynamicContentId = 387, CategoryId = 173},
new Links{Id = 130, SelfId = 388, BooksId = 389, DynamicContentId = 390, CategoryId = 174},
new Links{Id = 131, SelfId = 391, BooksId = 392, DynamicContentId = 393, CategoryId = 175},
new Links{Id = 132, SelfId = 394, BooksId = 395, DynamicContentId = 396, CategoryId = 176});
        });

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source=category.db");
        
//         .UseSeeding((context, _) =>
//         {

//             context.Set<Category>().Add(new Category { Id = 12, Image = new Uri("https://google.se"), Title = "CATEGORY"});

// context.Set<Category>().Add(new Category { ParentId = 12, Id = 13, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 12, Id = 14, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 12, Id = 15, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 12, Id = 16, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 12, Id = 17, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 2, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 2, Id = 5, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 2, Id = 6, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 2, Id = 8, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 2, Id = 11, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 2, Id = 177, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 54, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 160, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 161, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 55, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 56, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 57, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 58, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 59, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 60, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 61, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 62, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 63, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 64, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 65, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 66, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 67, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 54, Id = 68, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 27, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 27, Id = 30, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 27, Id = 32, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 27, Id = 33, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 48, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 48, Id = 49, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 48, Id = 50, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 48, Id = 51, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 48, Id = 52, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 48, Id = 53, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 20, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 20, Id = 162, Image = new Uri("https://google.se"), Title = "CATEGORY" });;
// context.Set<Category>().Add(new Category { ParentId = 20, Id = 22, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 20, Id = 23, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 85, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 86, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 87, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 88, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 89, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 90, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 91, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 92, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 93, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 94, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 95, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 96, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 84, Id = 97, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 38, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 38, Id = 41, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 38, Id = 43, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 38, Id = 45, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 38, Id = 47, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 98, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 98, Id = 99, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 98, Id = 100, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 98, Id = 101, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 98, Id = 102, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 98, Id = 103, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 98, Id = 105, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 34, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 34, Id = 36, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 34, Id = 37, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 73, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 24, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { Id = 155, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 156, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 157, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 158, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 159, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 112, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 112, Id = 113, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 114, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 115, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 116, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 155, Id = 117, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 118, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 118, Id = 119, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 118, Id = 120, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 118, Id = 121, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 118, Id = 122, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 118, Id = 123, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 124, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 124, Id = 125, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 124, Id = 126, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 124, Id = 127, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 124, Id = 128, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 124, Id = 129, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 130, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 130, Id = 131, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 130, Id = 132, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 130, Id = 133, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 130, Id = 134, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 130, Id = 135, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 136, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 136, Id = 137, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 136,  Id = 138, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 136,  Id = 139, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 136,  Id = 140, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 136, Id = 141, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 142, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 142, Id = 143, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 142, Id = 144, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 142, Id = 145, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 142, Id = 146, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 142, Id = 147, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 148, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 148, Id = 149, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 148, Id = 150, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 148, Id = 151, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 148, Id = 152, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 148, Id = 153, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 165, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 165, Id = 167, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 165, Id = 168, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 165, Id = 170, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 165, Id = 171, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { Id = 166, Image = new Uri("https://google.se"), Title = "CATEGORY" });
// context.Set<Category>().Add(new Category { ParentId = 166, Id = 172, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 166, Id = 173, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 166, Id = 174, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 166, Id = 175, Image = new Uri("https://google.se"), Title = "CATEGORY"});
// context.Set<Category>().Add(new Category { ParentId = 166, Id = 176, Image = new Uri("https://google.se"), Title = "CATEGORY"});


//         });



    

}}