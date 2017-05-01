import { inject } from "aurelia-framework";
import { MovieData } from "./movieData";
import { Router } from "aurelia-router";

@inject(MovieData, Router)
export class Edit {

    constructor(movieData, router) {
        this.data = movieData;
        this.router = router;
    }

    activate(params) {
        return this.data.getById(params.id)
            .then(movie => this.movie = movie);
    }  

   save() {
           this.data.save(this.movie)
               .then(movie => {
                   // get a generated url from the router
                   let url = this.router.generate("details", { id: movie.id });

                   // navigate to a url in the app
                   this.router.navigate(url);
           });
    }

}