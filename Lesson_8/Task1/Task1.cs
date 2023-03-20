using System.Text.RegularExpressions;

namespace Lesson_8
{
    internal class Task1
    {
        /// <summary>
        /// Создать класс, в котором будет статический метод.
        /// Этот метод принимает на вход три параметра:
        /// Login,
        /// Password,
        /// ConfirmPassword.
        /// Все поля имеют тип данных String.
        /// Длина login должна быть меньше 20 символов и не должен содержать пробелы.
        /// Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
        /// Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру.
        /// Также password и confirmPassword должны быть равны.
        /// Если password не соответствует этим требованиям, необходимовыбросить WrongPasswordException.
        /// WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию,
        /// второй принимает сообщение исключения и передает его в конструктор класса Exception.
        /// Метод возвращает true, если значения верны или false в другом случае.
        /// </summary>
        public static bool CreateAccount(string login, string password, string confirmPassword)
        {
            try
            {
                if ((login.Length > 19) || login.Contains(" "))
                {
                    throw new WrongLoginException("Login is wrong!");
                }

                if ((password.Length > 19) || (password.Contains(" ")) || !Regex.IsMatch(password, "[0-9]") || !password.Equals(confirmPassword))
                {
                    throw new WrongPasswordException("Password is wrong!");
                }
            }
            catch (WrongLoginException ex)
            {
                Console.Write(ex.Message + " ");
                return false;
            }
            catch (WrongPasswordException ex)
            {
                Console.Write(ex.Message + " ");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return true;
        }
    }
}
