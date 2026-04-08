namespace CodeWars.Completed;

public class L1BartenderDrinks
{
    public static string GetDrinkByProfession(string p)
    {
        Dictionary<string, string> drinks = new()
        {
            { "jabroni", "Patron Tequila" },
            { "school counselor", "Anything with Alcohol" },
            { "programmer", "Hipster Craft Beer" },
            { "bike gang member", "Moonshine" },
            { "politician", "Your tax dollars" },
            { "rapper", "Cristal" }
        };

        return drinks.ContainsKey(p.ToLower()) ? drinks[p.ToLower()] : "Beer";
    }
}
