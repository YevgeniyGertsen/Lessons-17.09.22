﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons_17._09._22.Modal;

/*
1.Создать абстрактный класс Издание с методами позволяющим вывести 
на экран информацию об издании, а также определить является ли данное издание искомым.
2.	Создать производные классы: Книга(название, фамилия автора, 
год издания, издательство), Статья(название, фамилия автора, название 
журнала, его номер и год издания), Электронный ресурс
(название, фамилия автора, ссылка, аннотация) со своими методами вывода информации на экран.
3.	Создать каталог (массив) из n изданий, вывести полную информацию из 
каталога, а также организовать поиск изданий по фамилии автора.
*/




namespace Lessons_17._09._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogEdition catalogEdition = new CatalogEdition();
            catalogEdition[0].GetEditionInfo();

        }
    }
}
