function GetAllHeroes() {
    $.ajax({
        url: "Service/SuperHeroesService.svc/GetAllHeroes",
        type: "GET",
        dataType: "json",
        success: function (result) {
            heroes = result;
            drawHeroTable(result)
        }

    })
}