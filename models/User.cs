using Dapper.Contrib.Extensions;

namespace models
{
    [Table("[User]")]
    public class User{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}