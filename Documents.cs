using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class Documents
{
    string code;
    string title;
    string section;
    int bookcase;
    string author;

    public Documents(string code, string title, string section, int bookcase, string author)
    {
        this.code = code;
        this.title = title;
        this.section = section;
        this.bookcase = bookcase;
        this.author = author;
    }

    public override string ToString()
    {
        var nl = Environment.NewLine;
        return $"code: {code}" + nl
            + $"title: {title}" + nl
            + $"section: {section}" + nl
            + $"bookcase: {bookcase}" + nl
            + $"author: {author}";
    }
}

public class Books : Documents
{
    int pages;

    public Books(string code, string title, string section, int bookcase, string author, int pages) : base( code, title, section, bookcase, author )
    {
        this.pages = pages;
    }

    public override string ToString() 
    {
        var nl = Environment.NewLine;
        return base.ToString() + nl
            + $"pages: {pages}" + nl;
    }
}

public class DVDs : Documents
{
    int duration;

    public DVDs(string code, string title, string section, int bookcase, string author, int duration) : base(code, title, section, bookcase, author)
    {
        this.duration = duration;
    }
    public override string ToString()
    {
        var nl = Environment.NewLine;
        return base.ToString() + nl
            + $"duration: {duration} min" + nl;
    }
}

//Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//-un codice identificativo di tipo stringa
//- titolo
//- anno
//- settore (storia, matematica, economia, …)
//-uno scaffale in cui è posizionato
//- un autore (Nome, Cognome)