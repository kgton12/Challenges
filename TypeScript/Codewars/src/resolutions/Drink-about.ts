export function peopleWithAgeDrink(old: number): string {
	const drinks = {
		Children: { age: 14, message: "drink toddy" },
		Teens: { age: 18, message: "drink coke" },
		Young: { age: 21, message: "drink beer" },
		Adult: { age: 22, message: "drink whisky" },
	};

	switch (true) {
		case old < drinks.Children.age:
			return drinks.Children.message;
		case old < drinks.Teens.age:
			return drinks.Teens.message;
		case old < drinks.Young.age:
			return drinks.Young.message;
		default:
			return drinks.Adult.message;
	}
}
