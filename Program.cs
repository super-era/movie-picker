using System;

namespace movie_picker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~Movie Picker~");

            Console.WriteLine("Hi there, I'm gonna help you pick a movie to watch!");
            Console.WriteLine("First, tell me what genre you're interested in! I have a few genres you can choose from:");
            Console.WriteLine("Action-adventure\nComedy\nFantasy\nRomance\nThriller");
            Console.WriteLine("Pick one of these genres:");
            var genre = Console.ReadLine().Trim().ToLower();
            if (genre == "thriller")
            {
                Console.WriteLine("Why don't you try Gone Girl (2014)?");
                Console.WriteLine("Set in Missouri, the story is a postmodern mystery that follows the events surrounding Nick Dunne, who becomes the prime suspect in the sudden disappearance of his wife Amy. ~ Wikipedia (https://en.wikipedia.org/wiki/Gone_Girl_(film)");

            }
            else if (genre == "comedy")
            {
                Console.WriteLine("Why don't you try Idiocracy (2006)?");
                Console.WriteLine("This film follows an American soldier who takes part in a classified hibernation experiment, only to be accidentally frozen for too long and awaken 500 years later in a dystopian world where dysgenics and commercialism have run rampant, mankind has embraced anti-intellectualism, and society is devoid of such traits as intellectual curiosity, social responsibility, justice, and human rights. ~ Wikipedia (https://en.wikipedia.org/wiki/Idiocracy)");

            }
            else if (genre == "fantasy")
            {
                Console.WriteLine("Why don't you try Harry Potter and the Chamber of Secrets (2002)?");
                Console.WriteLine("This film follows Harry Potter's second year at Hogwarts School of Witchcraft and Wizardry as the Heir of Salazar Slytherin opens the Chamber of Secrets, unleashing a monster that petrifies the school's denizens. ~ Wikipedia (https://en.wikipedia.org/wiki/Harry_Potter_and_the_Chamber_of_Secrets_(film))");
            }
            else if (genre == "action-adventure")
            {
                Console.WriteLine("Why don't you try Pirates of the Caribbean: The Curse of the Black Pearl (2003)?");
                Console.WriteLine("The story follows pirate Jack Sparrow and blacksmith Will Turner as they rescue the kidnapped Elizabeth Swann from the cursed crew of the Black Pearl, captained by Hector Barbossa, who become undead skeletons in moonlight. ~ Wikipedia (https://en.wikipedia.org/wiki/Pirates_of_the_Caribbean:_The_Curse_of_the_Black_Pearl)");
            }

            else if (genre == "romance")
            {
                Console.WriteLine("Why don't you try Atonement (2007)?");
                Console.WriteLine("Atonement is a 2007 romantic war drama film, based on Ian McEwan's 2001 novel of the same name. The film chronicles a crime and its consequences over the course of six decades, beginning in the 1930s. ~ Wikipedia (https://en.wikipedia.org/wiki/Atonement_(film))");
            }
            else
            {
                Console.WriteLine("I'm sorry, but I don't have any recommendations regarding that particular genre.");
            }

        }
    }
}
