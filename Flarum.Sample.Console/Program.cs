using Flarum.Provider;

var provider = new FlarumProvider();
provider.Option.Url = "https://community.wvbtech.com";
var user = await provider.GetFlarumUserByIdAsync(58);
Console.WriteLine($"Nickname:{user.DisplayName}");