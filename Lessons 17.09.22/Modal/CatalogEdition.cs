using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace Lessons_17._09._22.Modal
{
    public class CatalogEdition
    {
        private List<Edition> editions = new List<Edition>();
        public CatalogEdition()
        {
            editions.Add(new Book("АтаМура", DateTime.Now.Year)
            {
                Title = "Алые Паруса",
                AuthorsName = "Александр Грин",
                YearOfPublic = new DateTime(1916),
                Publisher = "Александр Грин"
            });
            editions.Add(new Article("Влияние телефонов на восприятие задания на задних партах", "Группа SEP-212"));
        }

        public Edition this[int number]
        {
            get 
            {
                return editions[number];
            }
            set 
            {
                editions[number] = value;
            }
        }
    }
}
