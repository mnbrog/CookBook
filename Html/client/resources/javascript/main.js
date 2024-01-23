// In script.js
document.addEventListener('DOMContentLoaded', function() {
    fetchRecipes();
});

function fetchRecipes() {
    fetch('api/recipe')
        .then(response => response.json())
        .then(data => {
            // Populate the recipes in the HTML
        });
}
