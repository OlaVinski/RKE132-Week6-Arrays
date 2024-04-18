string hello = " we are the champions?";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

//int wordCounter = 1;
//for(int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}

// Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

//IsWhiteSpace kontrollib, kas on tühik või mitte.

//Console.WriteLine(hello.Length);
//if (hello[i] == ' ')
//{
//    wordCounter++;
//}


//{
//    Console.WriteLine($"{i} symbol in string: {hello[i]}");
//}

//Console.WriteLine(stringLength);
//Console.WriteLine(trimmedString.Length);


//pikkus 13 --- loeb tühikud ja kirjavahemärgid
//esimene on 0, 1, 2, ...12 ja näitab 12+1=13
//kui kirjas 13, siis väärtus on length-1

//teksti lõpus olev tühik, mida seal ei tohiks olla

//TÄHE_SÜMBOLI MUUTMINE
//string sees ei saa lihtsalt üht ära võtta ja teist asemele panna