# Задача 1
## Класс «Дата».
Свойства: день, месяц, год, день недели (создать для этого перечисление). 
Методы: вычисление количества дней в месяце (заданном в свойстве месяц), проверка правильности даты, добавление к дате количества дней, месяцев и лет (соответственно, должен быть пересчёт даты, чтобы значение было правильным, например, если к 25.03.1980 добавить 10 дней, то должно получиться 04.04.1980, функция должна генерировать исключение, если дата неправильная).
## Запуск
Клонировать репозиторий локально к себе на проект.
```
git clone https://github.com/Eternity321/-.git
```
Перейти по следующему пути lab 1\ConsoleApp1\bin\Debug\net8.0 и запустить ConsoleApp1.

# Задача 2
 Класс «Живое существо».
Базовый класс: живое существо (свойство: скорость перемещения, абстрактные методы: двигаться, стоять)

Производные классы: пантера, собака, черепаха. реализовать методы двигаться и стоять. При этом неоднократный вызов, например, метода двигаться увеличивает скорость до максимально возможного и наоборот - вызов метода стоять, уменьшает вплоть до остановки. У пантеры и собаки должен быть метод - подать голос (определяется вызовом соответствующих событий), и пантера может залезть на дерево.
## Запуск
lab2 содержит в себе исходный код и файл StartApp.bat, который запускает приложение.

# Задача 3
 |Реализация рефлексии.
Задание: На основании реализованного второго таска, реализовать доступ к классам с помощью рефлексии.
## Запуск
lab3 содержит в себе исходный код и файл StartApp.bat, который запускает приложение. Для работы необходимо загрузить dll библиотеку из директории dlls