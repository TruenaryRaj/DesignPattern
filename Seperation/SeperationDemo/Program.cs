
public class UserRepository
{
    private List<string> users = new List<string>();

    public void AddUser(string user)
    {
        users.Add(user);
    }
    public List<string> GetUsers()
    {
        return users;
    }
}

public class UserService
{
    private UserRepository _userRepository;
    public UserService(UserRepository repository)
    {
        _userRepository = repository;
    }
    public void RegisterUser(string user)
    {
        _userRepository.AddUser(user);
    }
    public List<string> ListUsers()
    {
        return _userRepository.GetUsers();
    }
}

public class UserController
{
    private UserService _userService;
    public UserController(UserService userService)
    {
        _userService = userService;
    }
    public void CreateUser(string user)
    {
        _userService.RegisterUser(user);
    }
    public List<string> GetUsers()
    {
        return _userService.ListUsers();
    }
}
public class Program
{
    static void Main()
    {
        UserRepository userRepository = new UserRepository();
        UserService userService = new UserService(userRepository);
        UserController userController = new UserController(userService);
        userController.CreateUser("Ram");
        userController.CreateUser("Sam");
        List<string> users = userController.GetUsers();
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }

    }
}