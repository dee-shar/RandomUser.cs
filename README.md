# RandomUser.cs
Web-API for [randomuser.me](https://randomuser.me) A free, open-source API for generating random user data. Like Lorem Ipsum, but for people.

```cs
using RandomUserApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new RandomUser();
            string user = await api.GetRandomUser();
            Console.WriteLine(user);
        }
    }
}
```
