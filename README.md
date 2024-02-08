<h3>Метод для LINQ</h3>

Цель:
<ol>
<li>Напишите свой метод расширения с названием "Top" для коллекции IEnumerable, принимающий значение Х от 1 до 100 и возвращающий заданное количество процентов от выборки с округлением количества элементов в большую сторону.</li>
То есть для списка var list = new List{1,2,3,4,5,6,7,8,9};list.Top(30) должно вернуть 30% элементов от выборки по убыванию значений, то есть [9,8,7] (33%), а не [9,8] (22%).
Если переданное значение больше 100 или меньше 1, то выбрасывать ArgumentException.</li>
<li>Напишите перегрузку для метода "Top", которая принимает ещё и поле, по которому будут отбираться топ Х элементов. 
Например, для var list = new List{...}, вызов list.Top(30, person => person.Age) должен вернуть 30% пользователей с наибольшим возрастом в порядке убывания оного.</li>
</ol>
Описание/Пошаговая инструкция выполнения домашнего задания:
<ol>
<li>Создайте дженерик метод расширения для IEnumerable, возвращающий коллекцию, на которой был вызван;</li>
<li>Ограничьте количество элементов выходной коллекции;</li>
<li>Создайте дженерик перегрузку метода Top, добавив для этого одним из параметров функцию, принимающую T и возвращающую int;</li>
<li>Сделайте код-ревью (напишите свой отзыв) на одну из работ других студентов. Ссылки можете попросить в слаке. Для первого студента этот пункт опциональный (хотя и желательный), так как пока нет других работ.</li>
</ol>