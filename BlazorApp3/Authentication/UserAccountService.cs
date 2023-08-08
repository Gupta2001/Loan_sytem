using BlazorApp3.Authentication;

namespace BlazorApp3.Authentication
{
	public class UserAccountService
	{
		private List<UserAccount> _users;

		public UserAccountService()
		{
			_users = new List<UserAccount>
			{
				new UserAccount {UserName = "admin", Password="admin", Role = "admin"},
				new UserAccount{UserName = "user", Password="user", Role = "User"},
                new UserAccount{UserName = "Regional", Password="regional", Role = "manager1"},
                new UserAccount{UserName = "Head", Password="head", Role = "manager2"},
            };
		}

		public UserAccount? GetByUserName(string userName)
		{
			return _users.FirstOrDefault(x => x.UserName == userName);
		}
	}
}
