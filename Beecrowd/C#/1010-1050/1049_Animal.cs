
namespace Beecrowd._1010_1050
{
    public class _1049_Animal
    {
        public string Animal(string w1, string w2, string w3)
        {
            string word1, word2, word3;


            word1 = w1;
            word2 = w2;
            word3 = w3;

            if (word1 == "vertebrado")
            {
                if (word2 == "ave")
                {
                    if (word3 == "carnivoro")
                    {
                        return ("aguia");

                    }
                    else if (word3 == "onivoro")
                    {
                        return ("pomba");
                    }

                }
                else if (word2 == "mamifero")
                {
                    if (word3 == "onivoro")
                    {
                        return ("homem");

                    }
                    else if (word3 == "herbivoro")
                    {
                        return ("vaca");
                    }
                }

            }
            else if (word1 == "invertebrado")
            {
                if (word2 == "inseto")
                {
                    if (word3 == "hematofago")
                    {
                        return ("pulga");

                    }
                    else if (word3 == "herbivoro")
                    {
                        return ("lagarta");
                    }

                }
                else if (word2 == "anelideo")
                {
                    if (word3 == "hematofago")
                    {
                        return ("sanguessuga");

                    }
                    else if (word3 == "onivoro")
                    {
                        return ("minhoca");
                    }
                }
            }
            return ("Animal incorreto");
        }
    }
}
