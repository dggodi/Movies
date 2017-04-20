export class App {
    configureRouter(config, router) {
        this.router = router;

        // url for / or /#list
        config.map([
            {
                route: ["", "list"], moduleId: "movies/list",
                title: "List", nav: true, name: "home"
            },

            {
                route: "about", moduleId: "about/about",
                title: "About", nav: true
            },

            { route: "details", moduleId: "movies/details"}
        ]);
    }

}