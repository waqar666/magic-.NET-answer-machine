﻿// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
foreach (var arg in args)
{
    Console.Write(arg + ' ');
}
Console.WriteLine();
string[] answers =
[
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
];
var index = new Random().Next(answers.Length - 1);
await HelperMethods.Utilities.Showanimations();
Console.WriteLine(answers[index]);

