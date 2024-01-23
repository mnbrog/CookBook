// In Program.cs
[HttpGet]
public async Task<IActionResult> GetRecipes() {
    // Logic to fetch all recipes
}

[HttpPost]
public async Task<IActionResult> AddRecipe([FromBody]Recipe recipe) {
    // Logic to add a new recipe
}

// ... Other controller methods
