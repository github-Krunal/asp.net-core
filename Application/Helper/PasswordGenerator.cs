using System;


namespace Application.Helper
{
    public  class PasswordGenerator
    {
        private readonly byte _min_password_length=8;
        private readonly byte _max_password_length =16;
        private readonly Random _random = new Random();
        private readonly string  _lower_case = "abcdefghijklmnopqursuvwxyz";
        private readonly string _upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _numbers = "123456789";
        private readonly string _special_character = @"!@£$%^&*()#€";
        private string _generate_password;
        private int count=0;
        public string GeneratePassword()
        {
            int _password_length = _random.Next(_min_password_length, _max_password_length);
            do
            {
                int number = _random.Next(1, 5);
                switch (number)
                {
                    case 1:
                        int _random_lowerCase_number = _random.Next(0, _lower_case.Length - 1);
                        _generate_password += _lower_case[_random_lowerCase_number];
                        break;

                    case 2:
                        int _random_upperCase_number = _random.Next(0, _upper_case.Length - 1);
                        _generate_password += _upper_case[_random_upperCase_number];
                        break;

                    case 3:
                        int _random_number_number = _random.Next(0, _numbers.Length - 1);
                        _generate_password += _numbers[_random_number_number];
                        break;

                    default:
                        int _random_specialCharacter_number = _random.Next(0, _special_character.Length - 1);
                        _generate_password += _special_character[_random_specialCharacter_number];
                        break;
                }
                count = _generate_password.Length;
            }
            while (count <= _password_length-1);

            return _generate_password;
        }
    }
}
