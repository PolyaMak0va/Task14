using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    /* Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
     * абстрактное свойство - название животного.
     * В классе Animal нужно определить следующие методы:
     * конструктор, устанавливающий значение по умолчанию для названия;
     * абстрактный метод Say(), который выводит звук, который издает животное;
     * неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
     * Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
     * свойство – название животного;
     * метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
     * Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Cat("a cat"), new Dog("a dog") };
            foreach (var animal in animals)
            {
                animal.ShowInfo();
            }
            Cat cat = new Cat("a cat");
            Animal animal2 = cat;
            Dog dog = new Dog("a dog");
            Animal animal3 = dog;
            Console.WriteLine("Выберите животное: cat или dog");
            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case "cat":
                    {
                        if (animal2 is Cat)
                        {
                            Cat cat2 = (Cat)animal2;
                            cat.Say();
                        }
                        break;
                    }
                case "dog":
                    {
                        if (animal3 is Dog)
                        {
                            Dog dog2 = (Dog)animal3;
                            dog.Say();
                        }
                        break;
                    }    
                default:
                    {
                        Console.WriteLine("Введено некорректное значение");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
    abstract class Animal // в абстракт. классе Animal содержатся: методы, конструктор, определение звука
    {
        public abstract string TypeAnimal { get; set; }
        public abstract void Say(); // метод нужно реализовать в классе Наследники 

        public Animal(string type)
        {
            TypeAnimal = type;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Тип:  {0}", TypeAnimal);
            Say();
            Console.WriteLine();
        }
    }
    class Cat : Animal
    {
        string type;
        public Cat(string type)
            : base(type)
        {
            
        }
        public override string TypeAnimal
        {
            get
            {
                return type; // срабатывает при попытке получить значение
            }
            set
            {
                type = value; // срабатывает при попытке установить значение
            }
        }
        public override void Say()
        {
            Console.WriteLine("Звук: Meow-meow!");
        }
    }
    class Dog : Animal
    {
        string type;
        public Dog(string type)
            : base(type)
        {
            
        }
        public override string TypeAnimal
        {
            get
            {
                return type; // срабатывает при попытке получить значение
            }
            set
            {
                type = value; // срабатывает при попытке установить значение
            }
        }
        public override void Say()
        {
            Console.WriteLine("Звук: Woof-woof!");
        }
    }
}
