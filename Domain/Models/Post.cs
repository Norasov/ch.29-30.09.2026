namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public int CategoryId { get; set; }

    private static List<Post> posts = [];

    public static void CreatePost(string title, string description, int categoryId)
    {
        Post post = new Post();

        post.Id = posts.Count + 1;
        post.Title = title;
        post.Description = description;
        post.CategoryId = categoryId;
        post.CreatedAt = DateTime.Now;

        posts.Add(post);
    }

    public static List<Post> GetPosts()
    {
        return posts;
    }

    public static Post GetPostById(int id)
    {
        return posts.Find(x => x.Id == id)!;
    }

    public static Post GetPostByName(string name)
    {
        return posts.Find(x => x.Title == name)!;
    }

    public static List<Post> GetPostsByDate(DateTime date)
    {
        return posts.FindAll(x => x.CreatedAt.Date == date.Date);
    }

    public static List<Post> GetPostsByCategoryId(int id)
    {
        return posts.FindAll(x => x.CategoryId == id);
    }

    public static void DeletePost(int id)
    {
        posts.RemoveAll(x => x.Id == id);
    }
}