using ExempoPilhaDinamica;

BookPile bookPile = new BookPile();

Book book = new Book("As tranças do Rei Careca", "Papini", 2000);
Book book1 = new Book("As tranças do Rei Careca 2", "Papini", 2004);
Book book2 = new Book("Poeira em alto mar", "Pestana", 2020);

bookPile.Push(book);
bookPile.Push(book1);
bookPile.Push(book2);

bookPile.Print();