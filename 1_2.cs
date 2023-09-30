using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class TaxPayer
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public double AnnualIncome { get; set; }
    public double Tax { get; set; }
}

class Program
{
    static void Main()
    {
        List<TaxPayer> taxpayers = new List<TaxPayer>
        {
            new TaxPayer { LastName = "Кириллова", FirstName = "Олеся", AnnualIncome = 5697 },
            new TaxPayer { LastName = "Когай", FirstName = "Таисия", AnnualIncome = 34567 },
            new TaxPayer { LastName = "Чарушина", FirstName = "Кристина", AnnualIncome = 89076 },
            new TaxPayer { LastName = "Рюмина", FirstName = "Анна", AnnualIncome = 6758.76 }
        };

        Console.WriteLine("\nРезультаты расчета налога:\n");

        // Расчет и вывод налога для каждого налогоплательщика
        foreach (var taxpayer in taxpayers)
        {
            double tax = 0;

            if (taxpayer.AnnualIncome <= 20000)
            {
                tax = taxpayer.AnnualIncome * 0.12;
            }
            else if (taxpayer.AnnualIncome <= 40000)
            {
                tax = taxpayer.AnnualIncome * 0.20;
            }
            else
            {
                tax = taxpayer.AnnualIncome * 0.35;
            }

            taxpayer.Tax = tax;

            // Выводим результаты расчета налога на экран
            Console.WriteLine($"{taxpayer.LastName} {taxpayer.FirstName}, Налог: {taxpayer.Tax:F2} руб.");
        }

        // Указываем путь к файлу, в который хотим сохранить результаты
        string filePath = "/Users/olesyakirillova/Projects/tax_results.json";


        // Сериализуем список налогоплательщиков в JSON и сохраняем в файл
        string jsonResult = JsonConvert.SerializeObject(taxpayers, Formatting.Indented);
        File.WriteAllText(filePath, jsonResult);

        Console.ReadKey();
    }
}
