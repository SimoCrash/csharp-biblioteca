var product = new List<Documents>();

product.Add(new Books("efwe8f8x", "Harry Potter", "fantascienza", 14, "JK Rowling", 355));
product.Add(new DVDs("efwe832m", "Harry Potter2", "fantascienza", 15, "JK Rowling", 110));


foreach (var imm in product)
{
    Console.WriteLine(imm);
}

//    string code;
//string title;
//string section;
//int bookcase;
//string author;
//"efwe8f8x", "Harry Potter", "fantascienza", "ragazzi", "JK Rowling"