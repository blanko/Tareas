﻿using System;

namespace Tareas.Helpers;


public static class LoremWords
{
    private static readonly string[] Verbs =
    {
        "Hacer", "Crear", "Preparar", "Organizar", "Completar",
        "Iniciar", "Terminar", "Revisar", "Actualizar", "Eliminar"
    };

    private static readonly string[] LatinWords =
    {
        "exercitationem", "perferendis", "perspiciatis", "laborum", "eveniet",
        "sunt", "iure", "nam", "nobis", "eum", "cum", "officiis", "excepturi",
        "odio", "consectetur", "quasi", "aut", "quisquam", "vel", "eligendi",
        "itaque", "non", "odit", "tempore", "quaerat", "dignissimos",
        "facilis", "neque", "nihil", "expedita", "vitae", "vero", "ipsum",
        "nisi", "animi", "cumque", "pariatur", "velit", "modi", "natus",
        "iusto", "eaque", "sequi", "illo", "sed", "ex", "et", "voluptatibus",
        "tempora", "veritatis", "ratione", "assumenda", "incidunt", "nostrum",
        "placeat", "aliquid", "fuga", "provident", "praesentium", "rem",
        "necessitatibus", "suscipit", "adipisci", "quidem", "possimus",
        "voluptas", "debitis", "sint", "accusantium", "unde", "sapiente",
        "voluptate", "qui", "aspernatur", "laudantium", "soluta", "amet",
        "quo", "aliquam", "saepe", "culpa", "libero", "ipsa", "dicta",
        "reiciendis", "nesciunt", "doloribus", "autem", "impedit", "minima",
        "maiores", "repudiandae", "ipsam", "obcaecati", "ullam", "enim",
        "totam", "delectus", "ducimus", "quis", "voluptates", "dolores",
        "molestiae", "harum", "dolorem", "quia", "voluptatem", "molestias",
        "magni", "distinctio", "omnis", "illum", "dolorum", "voluptatum", "ea",
        "quas", "quam", "corporis", "quae", "blanditiis", "atque", "deserunt",
        "laboriosam", "earum", "consequuntur", "hic", "cupiditate",
        "quibusdam", "accusamus", "ut", "rerum", "error", "minus", "eius",
        "ab", "ad", "nemo", "fugit", "officia", "at", "in", "id", "quos",
        "reprehenderit", "numquam", "iste", "fugiat", "sit", "inventore",
        "beatae", "repellendus", "magnam", "recusandae", "quod", "explicabo",
        "doloremque", "aperiam", "consequatur", "asperiores", "commodi",
        "optio", "dolor", "labore", "temporibus", "repellat", "veniam",
        "architecto", "est", "esse", "mollitia", "nulla", "a", "similique",
        "eos", "alias", "dolore", "tenetur", "deleniti", "porro", "facere",
        "maxime", "corrupti"
    };

    public static string GenerateTitle(int wordCount = 2)
    {
        var random = new Random();
        var verb = Verbs[random.Next(Verbs.Length)];
       
        var words = new string[wordCount];
        for (int i = 0; i < wordCount; i++)
        {
            words[i] = LatinWords[random.Next(LatinWords.Length)];
        }
        
        return $"{verb} {string.Join(" ", words)}";
    }
}

