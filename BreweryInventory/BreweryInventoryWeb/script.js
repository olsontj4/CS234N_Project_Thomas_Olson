class Main {
    constructor() {
        this.state = {
            recipe: {
                "recipeId": 0,
                "name": "",
                "version": 0,
                "date": "",
                "styleId": 0,
                "volume": 0,
                "brewer": "",
                "boilTime": 0,
                "boilVolume": 0,
                "efficiency": 0,
                "fermentationStages": 0,
                "estimatedOg": 0,
                "estimatedFg": 0,
                "estimatedColor": 0,
                "estimatedAbv": 0,
                "actualEfficiency": 0,
                "equipmentId": 0,
                "carbonationUsed": "",
                "forcedCarbonation": 0,
                "kegPrimingFactor": 0,
                "carbonationTemp": 0,
                "mashId": 0,
                "batches": [],
                "equipment": null,
                "mash": null,
                "recipeIngredients": [],
                "style": null
            }
        };

        this.BindAllMethods();
        this.AddLinks();
        this.FetchRecipes();

        this.server = "http://localhost:44398/api"
        this.url = this.server + "/Recipes";
    }
    BindAllMethods() {
        this.AddLinks = this.AddLinks.bind(this);
        this.FetchRecipes = this.FetchRecipes.bind(this);
        this.LoadRecipes = this.LoadRecipes.bind(this);
    }
    AddLinks() {
        document.getElementById("RecipesLink").href += "Recipes/index.html";
        document.getElementById("LogoLink").href += "index.html";
    }
    FetchRecipes() {
        fetch(`${this.server + this.url}`)
            .then(response => response.json())
            .then(data => {
                if (data.length == 0) {
                    alert("Can't load recipes.");
                }
                else {
                    this.state.recipe = data;
                    this.LoadRecipes();
                }
            })
            .catch(error => {
                console.error(error);
                alert('There was a problem getting recipe info!');
            });
    }
    LoadRecipes() {
        this.$recipeState.innerHTML = this.state.recipe;
    }
}

window.onload = () => {
    new Main();
};