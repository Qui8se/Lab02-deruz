// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробных типов данных");
// Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"Double: {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"Decimal: {decimal.MinValue} .. {decimal.MaxValue}");



// Console.WriteLine();
// Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overFlowed = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overFlowed}");



// Console.WriteLine();
// Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter;  // char можно неявно превратить в int - это код символа в таблице Unicode
// Console.WriteLine($"Символ: {firstLetter}, раздделитель: {separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");




// Console.WriteLine();
// Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");




// Console.WriteLine();
// Console.WriteLine("var");

// var studentAge = 20;
// var gpa = 4.75;
// var fullName = "Смирнова А.С.";

// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");





// Console.WriteLine();
// Console.WriteLine("Ввод текста");

// Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();

// Console.Write("Введите название вашй группы: ");
// string enteredGroup = Console.ReadLine();

// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");





// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");

// Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse: {birthYearParse}");
// Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");





// Console.WriteLine();
// Console.WriteLine("Ввод чисел: TryParse");

// Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// Console.WriteLine($"Удалось преобразовать:  {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount: {booksCount}");






// Console.Write("Введите имя и фамилию: ");
// string nameInput = Console.ReadLine();

// Console.Write("Введите группу: ");
// string groupInput = Console.ReadLine();

// Console.Write("Введите год рождения: ");
// string birthYearInput = Console.ReadLine();
// int birthYearParse = int.Parse(birthYearInput);

// Console.Write("Введите средний балл: ");
// string averageScoreInput = Console.ReadLine();
// double averageScore = double.Parse(averageScoreInput);

// Console.Write("Введите любимую букву: ");
// string favoriteLetter = Console.ReadLine();

// bool score = true;

// Console.WriteLine();
// Console.WriteLine("Анкета");
// Console.WriteLine($"{nameInput}, Группа {groupInput}");
// Console.WriteLine($"Год рождения: {birthYearParse} (в 2030 будет {2030 - birthYearParse})");
// Console.WriteLine($"Средний балл: {averageScore}");
// Console.WriteLine($"Балл >= 4.0: {score}");
// Console.WriteLine($"Любимая буква: {favoriteLetter}");








Console.Write("Введите ваш рост: ");
string heightInput = Console.ReadLine();
double height = double.Parse(heightInput);

Console.Write("Введите ваш вес: ");
string weightInput = Console.ReadLine();
double weight = double.Parse(weightInput);

double imt = weight / (height * height);

Console.WriteLine($"Ваш ИМТ : {imt:F2}");