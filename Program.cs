﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Начинаем");
string [] str = new string [10];
str[0] = "Не совершай классическую ошибку всех умников: не думай, что нет людей умнее тебя.";
str[1] = "Все мы гении. Но если вы будете судить рыбу по её способности взбираться на дерево, она проживёт всю жизнь, считая себя дурой.";
str[2] = "Безвыходным мы называем положение, выход из которого нам не нравится.";
str[3] = "Нужно иметь что-то общее, чтобы понимать друг друга, и чем-то отличаться, чтобы любить друг друга.";
str[4] = "Жизнь состоит не в том, чтобы найти себя. Жизнь состоит в том, чтобы создать себя.";
str[5] = "Они научили меня ценить верность... И никогда не забывать о тех, кого любишь.";
str[6] = "... самый страшный гнев, гнев бессилия.";
str[7] = "Несчастным или счастливым человека делают только его мысли, а не внешние обстоятельства. Управляя своими мыслями, он управляет своим счастьем.";
str[8] = "Пройдите мимо нас и простите нам наше счастье.";
str[9] = "Любовь не терпит объяснений. Ей нужны поступки.";

string [] SplitString (string SourseStr)
{
    string [] ArrayOfString = SourseStr.Split(" ");
    return ArrayOfString;
}

void ThreeCharMax (string [] SourseString)
{
foreach (string Item in SourseString)
{
   int Length = Item.Length;
   if (Length<4) 
   {
Console.WriteLine(Item);
   }
    
}

}
 ThreeCharMax (SplitString(str[0]));