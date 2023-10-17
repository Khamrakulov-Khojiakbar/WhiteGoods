// See https://aka.ms/new-console-template for more information
using Npgsql;

Console.WriteLine("Введите пароль от DB");
string inputPassword = Console.ReadLine();

if (inputPassword == "1221")
{
    Console.WriteLine("Внимание пароль должен быть не менее 8 символов\n");
    Console.WriteLine("Ждите...");
    Thread.Sleep(3000);
    Console.Clear();
    Console.Write("Введите новый пароль для настроек программы: ");
    string? password = Console.ReadLine();
    if(password != null)
    {
        if(password.Length < 8)
        {
            Console.WriteLine("Внимание пароль должен быть не менее 8 символов");
        }
        else
        {
            string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";

            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdQuery = @"update WinFormsPassword set password = @newPassword";

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Parameters.AddWithValue("@newPassword", password);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        
    }
    else
        Console.WriteLine("Ошибка! Пароль не может быть пустым!");

    Thread.Sleep(3000);
}

Console.Clear();

Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
Console.ReadLine();


