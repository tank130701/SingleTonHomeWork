// Класс DatabaseConnection, который реализует Singleton
public class DatabaseConnection {

    // Статическая переменная для хранения единственного экземпляра
    private static DatabaseConnection instance;

    // Приватный конструктор, чтобы предотвратить создание других экземпляров
    private DatabaseConnection() {
        // Инициализация подключения к базе данных
    }

    // Статический метод для получения экземпляра
    public static DatabaseConnection getInstance() {
        // Если экземпляр еще не создан, то создаем его
        if (instance == null) {
            instance = new DatabaseConnection();
        }
        // Возвращаем экземпляр
        return instance;
    }

    // Метод для выполнения запросов к базе данных
    public void executeQuery(String query) {
        // Реализация логики выполнения запросов
    }
}

// Класс Client, который использует DatabaseConnection
public class Client {

    public static void test(String[] args) {
        // Получаем экземпляр DatabaseConnection
        DatabaseConnection connection = DatabaseConnection.getInstance();

        // Выполняем запросы к базе данных
        connection.executeQuery("SELECT * FROM users");
        connection.executeQuery("INSERT INTO users VALUES ('Alice', 25)");
    }
}

// Класс Main, который запускает приложение
public class Program {

    static void Main(String[] args) {
        // Создаем экземпляр Client
        Client client = new Client();
        Console.WriteLine(client.GetHashCode());
        Client client2 = new Client();
        Console.WriteLine(client.GetHashCode());
    }
}
