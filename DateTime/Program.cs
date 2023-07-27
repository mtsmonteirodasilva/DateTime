DateTime data1 = new DateTime(2023, 07, 28);
DateTime data2 = new DateTime(2023, 07, 24);

//0 - Datas são iguais
// -1 - A primeira data é anterior a segunda
// 1 - A primeira data é posterior a segunda
int retornoCompararDatas = DateTime.Compare(data2, data1);
Console.WriteLine(retornoCompararDatas);

//Console.WriteLine("Informe uma data");
//DateTime datasim = DateTime.Parse(Console.ReadLine());
//Console.WriteLine(datasim);

DateTime data3 = DateTime.Parse("07/04/2022");
DateTime data4 = DateTime.Parse("07-04-2022");

Console.WriteLine(data3);
Console.WriteLine(data4);

DateOnly dto = DateOnly.Parse("07-04-2022");
Console.WriteLine(dto);

//Console.Write("Informe a data de nascimento: ");
//DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine(dataNasc.DayOfWeek);

DateTime d1 = new DateTime(2023, 07, 24);
DateTime d2 = new DateTime(2006, 11, 17, 15, 50, 0);

//DateTime d3 = d1.AddDays(10);
//DateTime d4 = d2.AddYears(2);

//Console.WriteLine(d1);
//Console.WriteLine(d2);

//Console.WriteLine(d3);
//Console.WriteLine(d4);

TimeSpan d5 = d1 - d2;
//TimeSpan a1 = d1.Subtract(d2);

TimeSpan a = new TimeSpan(6093, 00, 00, 00);
DateTime novadata =  DateTime.Now.Subtract(a);

Console.WriteLine(d5);
//Console.WriteLine(a1);
Console.WriteLine(novadata);