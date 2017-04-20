import { inject } from "aurelia-framework";
import { MovieData } from "./movieData";

@inject(MovieData)
export class Details {

    constructor(movieData) {
        this.data = movieData;
    }

    // params -     id passed in url
    activate(params) {
        return this.data.getById(params.id)
            .then(movie => this.movie = movie);
    }
}